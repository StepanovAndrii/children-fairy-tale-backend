using Mapster;
using System.Reflection;

namespace Infrastructure.Mappings
{
    public class MapsterConfiguration
    {
        public static void RegisterMapsterConfig()
        {
            var config = TypeAdapterConfig.GlobalSettings;
            config.Scan(Assembly.Load("Application"));
        }
    }
}
