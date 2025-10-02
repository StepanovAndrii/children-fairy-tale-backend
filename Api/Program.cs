using Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddAuthentication(options =>
{
    options.DefaultScheme = "Cookie";
    options.DefaultChallengeScheme = "Google";
})
.AddCookie("Cookie")
.AddGoogle(options =>
{
    builder.Configuration.Bind("Authentication:Google", options);
});
builder.Services.AddAuthorization();

builder.Services.AddCors(options =>
{
    options.AddPolicy("Angular:Development", policy =>
    {
        policy.WithOrigins("http://localhost:4200")
            .AllowAnyHeader()
            .AllowAnyMethod()
            .AllowCredentials();
    });
});

var app = builder.Build();

var apiGroup = app.MapGroup("/api");
AuthEndpoints.MapAuthEndpoints(apiGroup);

app.UseCors("Angular:Development");
app.UseAuthentication();
app.UseAuthorization();
app.Run();