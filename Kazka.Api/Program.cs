using Domain.Enums;
using Infrastructure.Extensions.Security;
using Kazka.Api.Attributes;
using Kazka.Api.Extensions;
using Kazka.Api.Settings;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using Persistence.Contexts;
using System.IdentityModel.Tokens.Jwt;
using System.Reflection;
using System.Security.Claims;
using System.Text;
using System.Text.Json;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApiSettings(builder.Configuration);
builder.Services.AddCustomCors(builder.Configuration);
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<KazkaContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSQL")));

var jwtSecret = builder.Configuration["Jwt:Secret"];
if (jwtSecret is null)
    throw new InvalidOperationException("JWT secret is not configured.");

var key = Encoding.UTF8.GetBytes(jwtSecret);

var endpointTypes = Assembly.GetExecutingAssembly()
    .GetTypes()
    .Where(type => typeof(IEndpoint).IsAssignableFrom(type)
        && !type.IsInterface
        && !type.IsAbstract);

foreach (var type in endpointTypes)
{
    builder.Services.AddTransient(type);
}

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Default");

var optionsApi = app.Services
    .GetRequiredService<IOptions<ApiSettings>>()
    .Value;

var apiGroup = app.MapGroup($"/api/{optionsApi.Version}")
    .RequireAuthorization();

var adminGroup = apiGroup.MapGroup("/admin")
    .RequireAuthorization("AdminOnly")
    .WithTags("Admin");

foreach (var type in endpointTypes)
{
    var endpoint = app.Services.GetRequiredService(type) as IEndpoint;

    var isAdmin = type.GetCustomAttribute<AdminEndpointAttribute>() != null;
    var group = isAdmin ? adminGroup : apiGroup;

    endpoint?.Map(group);
}

app.Run();