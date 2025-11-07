using Kazka.Api.Attributes;
using System.Reflection;
using Asp.Versioning;
using Kazka.Infrastructure.Exceptions;

namespace Kazka.Api.Extensions
{
    public static class EndpointExtensions
    {
        public static IEnumerable<Type>? AddAllEndpoints(this IServiceCollection services)
        {
            var endpointTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(t => typeof(IEndpoint).IsAssignableFrom(t)
                    && !t.IsInterface
                    && !t.IsAbstract);

            foreach (var type in endpointTypes)
            {
                services.AddTransient(type);
            }

            return endpointTypes;
        }
        public static void MapAllEndpoints
            (
                this WebApplication app,
                IEnumerable<Type>? endpointTypes
            )
        {
            if (endpointTypes is null)
                return;

            var versions = endpointTypes
                .Select(type => type.GetCustomAttribute<EndpointVersionAttribute>()?.Version ?? 1)
                .Distinct()
                .OrderBy(version => version)
                .ToList();

            if (versions is null)
                throw new InvalidConfigurationException("There must be at least version 1!");

                var versionSetBuilder = app.NewApiVersionSet();
                foreach (var version in versions)
                    versionSetBuilder.HasApiVersion(new ApiVersion(version, 0));
                var versionSet = versionSetBuilder.Build();

                foreach (var type in endpointTypes)
                {
                    var version = type.GetCustomAttribute<EndpointVersionAttribute>();
                    var apiGroup = app.MapGroup($"/api/v{version!.Version}");
                    var adminGroup = apiGroup.MapGroup("/admin");

                    var endpoint = app.Services.GetRequiredService(type) as IEndpoint;
                
                    var isAdmin = type.GetCustomAttribute<AdminEndpointAttribute>() != null;
                    var group = isAdmin ? adminGroup : apiGroup;

                    endpoint?.Map(group);
                }
        } 
    }
}
