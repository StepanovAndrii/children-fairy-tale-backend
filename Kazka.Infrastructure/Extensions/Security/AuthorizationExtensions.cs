using Domain.Enums;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Extensions.Security
{
    public static class AuthorizationExtensions
    {
        public static IServiceCollection AddCustomAuthorization
            (
                this IServiceCollection services
            )
        {
            services.AddAuthorization(
                options =>
                {
                    options.AddPolicy("AdminOnly", policy =>
                        policy.RequireRole(nameof(UserRole.Admin)));
                }
            );

            return services;
        }
    }
}
