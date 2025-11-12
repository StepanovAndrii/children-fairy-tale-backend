using Domain.Entities;
using Infrastructure.Extensions.Security;
using Kazka.Api.Extensions;
using Kazka.Api.Handlers;
using Kazka.Application.Extensions;
using Kazka.Infrastructure.Configuration;
using Kazka.Infrastructure.Extensions;
using Kazka.Infrastructure.Extensions.Security;
using Kazka.Infrastructure.Options;
using Kazka.Persistence.Extensions;
using Microsoft.AspNetCore.Identity;
using Persistence.Contexts;
using Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// ---- DI ----
builder.Services.AddInfrastractureDI();
builder.Services.AddApplicationDI();
builder.Services.AddPersistenceDI();

builder.Services.AddHttpContextAccessor();

// ---- CORS ----
builder.Services.AddCustomCors(builder.Configuration);

// ---- Configuration deserialization ----
builder.Services.Configure<JwtOptions>(
    builder.Configuration.GetSection(JwtOptions.JwtOptionsKey));
builder.Services.Configure<GoogleOptions>(
    builder.Configuration.GetSection("Authentication:Google"));

// ---- Enum to string conversion ----
builder.Services.AddEnumConversionConfig();

// ---- Swagger ----
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ____ Authentication & Authorization ----
builder.Services.AddCustomAuthentication(builder.Configuration);
builder.Services.AddCustomAuthorization();

// ---- Identity registration ----
builder.Services.AddIdentity<User, IdentityRole<int>>(
    options =>
    {
        options.User.RequireUniqueEmail = true;
    }
).AddEntityFrameworkStores<KazkaContext>();

// ---- DbContexts ----
builder.Services.AddDbContexts(builder.Configuration);

// ---- Endpoints registration ----
var endpointTypes = builder.Services.AddAllEndpoints();

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();

var app = builder.Build();

// ---- Middleware pipeline ----
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseExceptionHandler("/error");
}

//app.UseExceptionHandler(_ => { });
app.UseCors("Default");
app.UseAuthentication();
app.UseAuthorization();

// ---- Endpoints mapping ----
app.MapAllEndpoints(endpointTypes);

app.Run();