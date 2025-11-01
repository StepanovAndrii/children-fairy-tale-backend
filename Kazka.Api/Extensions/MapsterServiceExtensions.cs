using Mapster;
using MapsterMapper;

namespace Kazka.Api.Extensions
{
    public static class MapsterServiceExtensions
    {
        public static IServiceCollection AddMapsterConfigurations
            (
                this IServiceCollection services
            )
        {
            var config = TypeAdapterConfig.GlobalSettings;

            var assemblies = AppDomain.CurrentDomain
                .GetAssemblies()
                .Where(assembly => assembly.GetName().Name!.StartsWith("Kazka"))
                .ToArray();

            config.Scan(assemblies);

            services.AddSingleton(config);
            services.AddSingleton<IMapper, ServiceMapper>();

            return services;
        }
    }
}
