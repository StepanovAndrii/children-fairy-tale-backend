using Kazka.Api.Attributes;
using Kazka.Api.Settings;
using Microsoft.Extensions.Options;
using System.Reflection;

namespace Kazka.Api.Extensions
{
    public static class EndpointExtensions
    {
        public static void AddAllEndpoints(this IServiceCollection services)
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
        }
        public static void MapAllEndpoints(this WebApplication app)
        {
            var options = app.Services
                .GetRequiredService<IOptions<ApiSettings>>()
                .Value;

            var apiGroup = app.MapGroup($"/{options.Version}")
                .RequireAuthorization();

            var adminGroup = apiGroup.MapGroup("/admin")
                .RequireAuthorization("AdminOnly")
                .WithTags("Admin");

            var endpointTypes = Assembly.GetExecutingAssembly()
                .GetTypes()
                .Where(type => typeof(IEndpoint).IsAssignableFrom(type)
                    && !type.IsInterface
                    && !type.IsAbstract);

            foreach (var type in endpointTypes)
            {
                var endpoint = app.Services.GetRequiredService(type) as IEndpoint;
                
                var isAdmin = type.GetCustomAttribute<AdminEndpointAttribute>() != null;
                var group = isAdmin ? adminGroup : apiGroup;

                endpoint?.Map(group);
            }
        } 
    }
}
