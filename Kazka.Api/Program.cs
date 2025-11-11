using Infrastructure.Extensions.Security;
using Kazka.Api.Extensions;
using Kazka.Application.Extensions;
using Kazka.Infrastructure.Configuration;
using Kazka.Infrastructure.Extensions;
using Kazka.Infrastructure.Extensions.Security;
using Kazka.Persistence.Extensions;
using Persistence.Extensions;

var builder = WebApplication.CreateBuilder(args);

// ---- DI ----
builder.Services.AddApplicationDI();
builder.Services.AddInfrastractureDI();
builder.Services.AddPersistenceDI();

// ---- CORS ----
builder.Services.AddCustomCors(builder.Configuration);

// ---- Configuration deserialization ----
builder.Services.Configure<JwtOptions>(
    builder.Configuration.GetSection("Jwt"));
builder.Services.Configure<GoogleOAuthOptions>(
    builder.Configuration.GetSection("Authentication:Google"));

// ---- Enum to string conversion ----
builder.Services.AddEnumConversionConfig();

// ---- Swagger ----
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ____ Authentication & Authorization ----
builder.Services.AddCustomAuthentication();
builder.Services.AddCustomAuthorization();

// ---- DbContexts ----
builder.Services.AddDbContexts(builder.Configuration);

// ---- Endpoints registration ----
var endpointTypes = builder.Services.AddAllEndpoints();

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
app.MapAllEndpoints(endpointTypes);

app.Run();