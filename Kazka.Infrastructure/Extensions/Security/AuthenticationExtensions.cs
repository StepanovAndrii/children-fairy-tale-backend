using Kazka.Infrastructure.Configuration;
using Kazka.Infrastructure.Options;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Kazka.Infrastructure.Extensions.Security
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection AddCustomAuthentication
            (
                this IServiceCollection services,
                IConfiguration configuration
            )
        {
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddGoogle(options =>
            {
                var googleOptions = configuration.GetSection("Authentication:Google")
                    .Get<GoogleOptions>() ?? throw new ArgumentException(nameof(GoogleOptions));

                options.ClientId = googleOptions.ClientId;
                options.ClientSecret = googleOptions.ClientSecret;
                options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;


                // TODO: delete hardcode
                options.CallbackPath = "/api/v1/auth/google/callback";

                options.SaveTokens = true;
            })
            .AddJwtBearer(options =>
            {
                var jwtOptions = configuration.GetSection("JwtOptions")
                    .Get<JwtOptions>() ?? throw new ArgumentException(nameof(JwtOptions));

                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtOptions!.Issuer,
                    ValidAudience = jwtOptions.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtOptions.Secret)
                    )
                };
            });

            return services;
        }
    }
}
