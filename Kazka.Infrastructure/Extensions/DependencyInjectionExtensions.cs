using Infrastructure.Services;
using Kazka.Application.Interfaces.External;
using Kazka.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Kazka.Infrastructure.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastractureDI
            (
                this IServiceCollection services
            )
        {
            services.AddScoped<GoogleOAuthEventsHandler>();
            services.AddHttpContextAccessor();
            services.AddScoped<ICurrentUserService, CurrentUserService>();

            return services;
        }
    }
}
