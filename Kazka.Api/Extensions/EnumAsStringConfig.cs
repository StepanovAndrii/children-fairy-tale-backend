using System.Text.Json.Serialization;

namespace Kazka.Api.Extensions
{
    public static class EnumAsStringConfig
    {
        public static IServiceCollection AddEnumConversionConfig(this IServiceCollection services)
        {
            services.ConfigureHttpJsonOptions(options =>
            {
                options.SerializerOptions.Converters.Add(new
                    JsonStringEnumConverter());
            });

            return services;
        }
    }
}
