using Kazka.Api.Settings;

namespace Kazka.Api.Extensions
{
    public static class ApiSettingsExtension
    {
        public static IServiceCollection AddApiSettings
            (
                this IServiceCollection services,
                IConfiguration configuration
            )
        {
            services.Configure<ApiSettings>(configuration.GetSection("ApiSettings"));
            return services;
        }
    }
}
