using Kazka.Application.Interfaces.Services.External;
using Kazka.Infrastructure.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Kazka.Infrastructure.Extensions
{
    public static class DependencyInjectionExtensions
    {
        public static IServiceCollection AddInfrastractureDI(this IServiceCollection services)
        {
            services.AddScoped<IAuthTokenService, AuthTokenService>();

            return services;
        }
    }
}
