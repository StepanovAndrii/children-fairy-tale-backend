using Api.Endpoints;
using Application.Interfaces.Services;
using Application.Services;
using Domain.Enums;
using Domain.Interfaces.Repositories;
using Infrastructure.Mappings;
using Infrastructure.Services;
using Mapster;
using MapsterMapper;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using Persistence.Repositories;
using System.Security.Claims;

var builder = WebApplication.CreateBuilder(args);

MapsterConfiguration.RegisterMapsterConfig();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddSingleton(TypeAdapterConfig.GlobalSettings);
builder.Services.AddScoped<IOAuthService, OAuthService>();
builder.Services.AddScoped<IStoryService, StoryService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
builder.Services.AddScoped<IStoryRepository, StoryRepository>();
builder.Services.AddScoped<IChapterRepository, ChapterRepository>();
builder.Services.AddScoped<ILanguageRepository, LanguageRepository>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddScoped<MapsterMapper.IMapper, ServiceMapper>();

builder.Services.AddScoped<Application.Interfaces.IMapper, MapsterMapperAdapter>();

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookie";
    options.DefaultChallengeScheme = "Google";
})
.AddCookie("Cookie")
.AddGoogle(options =>
{
    builder.Configuration.Bind("Authentication:Google", options);

    options.Scope.Add("email");
    options.Scope.Add("profile");

    options.ClaimActions.MapJsonKey("pictureUrl", "picture");

    options.Events.OnCreatingTicket = async context =>
    {
        using var scope = context.HttpContext.RequestServices.CreateScope();
        var oauthService = scope.ServiceProvider.GetRequiredService<IOAuthService>();

        var claims = context.Principal?.Claims.ToList();
        var email = claims?.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
        var googleId = claims?.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
        var picture = claims?.FirstOrDefault(c => c.Type == "pictureUrl")?.Value;

        if (string.IsNullOrWhiteSpace(email) 
            || string.IsNullOrWhiteSpace(googleId))
            return;

        var user = await oauthService.RegisterUserAsync(
            googleId,
            email,
            picture
        );

        var identity = (ClaimsIdentity?)context.Principal!.Identity!;
        identity.AddClaim(new Claim(ClaimTypes.Role, user.Role.ToString()));
    };
});
builder.Services.AddAuthorization(
    options =>
    {
        options.AddPolicy("AdminOnly", policy =>
        {
            policy.RequireRole(UserRole.Admin.ToString());
        });
    }    
);

builder.Services.AddCors(options =>
{
    options.AddPolicy("Angular:Development", policy =>
    {
        policy.WithOrigins(
                "http://localhost:4200",
                "https://localhost:7209"
            )
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

builder.Services.AddDbContext<KazkaDbContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL"))
);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

var apiGroup = app.MapGroup("/api/v1");
OAuthEndpoints.MapAuthEndpoints(apiGroup);
UserEndpoints.MapAuthEndpoints(apiGroup);
StoryEndpoints.MapAuthEndpoints(apiGroup);
ChapterEndpoints.MapAuthEndpoints(apiGroup);
CategoryEndpoints.MapAuthEndpoints(apiGroup);

app.UseCors("Angular:Development");
app.UseAuthentication();
app.UseAuthorization();
app.Run();