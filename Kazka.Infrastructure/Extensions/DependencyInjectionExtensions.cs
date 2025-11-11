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
            services.AddHttpContextAccessor();

            services.Scan(scan => scan
                .FromAssemblyOf<CurrentUserService>()
                .AddClasses()
                .AsMatchingInterface()
                .WithScopedLifetime());

            return services;
        }
    }
}
