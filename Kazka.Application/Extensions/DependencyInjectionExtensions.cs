using Kazka.Application.BusinessLogic;
using Kazka.Application.Interfaces.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Kazka.Application.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddApplicationDI(this IServiceCollection services)
        {
            services.Scan(scan => scan
                .FromAssemblyOf<UserBusinessLogic>()
                .AddClasses()
                .AsMatchingInterface()
                .WithScopedLifetime());

            return services;
        }
    }
}
