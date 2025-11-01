using Api.Endpoints.Auth;
using Api.Endpoints.Stories;
using Infrastructure.Extensions;
using Infrastructure.Extensions.Security;
using Infrastructure.Extensions.Security.Authentication;
using Kazka.Api.Extensions;
using Kazka.Application.Extensions;
using Kazka.Infrastructure.Extensions;
using Kazka.Persistence.Extensions;
using Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// ---- DI ----
builder.Services.AddApplicationDI();
builder.Services.AddInfrastractureDI();
builder.Services.AddPersistenceDI();

// ---- API configuration ----
builder.Services.AddApiSettings(builder.Configuration);

// ---- CORS ----
builder.Services.AddCustomCors(builder.Configuration);

// ---- Swagger ----
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ____ Authentication & Authorization ----
builder.Services.AddCustomAuthentication
    (
        builder.Configuration,
        builder.Environment
    );
builder.Services.AddCustomAuthorization();

// ---- DbContexts ----
builder.Services.AddDbContexts(builder.Configuration);

// ---- MediatR ----
builder.Services.AddApplicationMediator();

// ---- Mapster ----
builder.Services.AddMapsterConfigurations();

// ---- Endpoints registration ----
builder.Services.AddAllEndpoints();

var app = builder.Build();

// ---- Middleware pipeline ----
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("Default");
app.UseAuthentication();
app.UseAuthorization();

// ---- Endpoints mapping ----
app.MapAllEndpoints();

app.Run();