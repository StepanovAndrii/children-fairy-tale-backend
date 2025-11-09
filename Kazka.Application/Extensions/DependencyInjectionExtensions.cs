using Kazka.Application.BusinessLogic;
using Microsoft.Extensions.DependencyInjection;

namespace Kazka.Application.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssemblyOf<AuthBusinessLogic>()
                .AddClasses()
                .AsMatchingInterface()
                .WithScopedLifetime());

            return services;
        }
    }
}
