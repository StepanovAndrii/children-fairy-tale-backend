using Kazka.Infrastructure.Configuration;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Kazka.Infrastructure.Extensions.Security
{
    public static class AuthenticationExtensions
    {
        public static IServiceCollection AddCustomAuthentication
            (
                this IServiceCollection services
            )
        {
            using var provider = services.BuildServiceProvider();
            var jwtOptions = provider.GetRequiredService<IOptions<JwtOptions>>().Value;
            var googleOptions = provider.GetRequiredService<IOptions<GoogleOAuthOptions>>().Value;

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuer = true,
                    ValidateAudience = true,
                    ValidateLifetime = true,
                    ValidateIssuerSigningKey = true,
                    ValidIssuer = jwtOptions.Issuer,
                    ValidAudience = jwtOptions.Audience,
                    IssuerSigningKey = new SymmetricSecurityKey(
                        Encoding.UTF8.GetBytes(jwtOptions.Key)
                    )
                };
            })
            .AddGoogle(options =>
            {
                options.ClientId = googleOptions.ClientId;
                options.ClientSecret = googleOptions.ClientSecret;
                options.CallbackPath = googleOptions.CallbackPath;

                options.Scope.Add("profile");
                options.Scope.Add("email");
                options.ClaimActions.MapJsonKey("picture", "picture");
            });

            return services;
        }
    }
}
