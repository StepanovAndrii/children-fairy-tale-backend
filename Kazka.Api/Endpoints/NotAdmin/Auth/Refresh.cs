using Kazka.Api.Attributes;

namespace Kazka.Api.Endpoints.NotAdmin.Auth
{
    [EndpointVersion(1)]
    public class Refresh : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapPost("tokens/refresh", async
                (
                    HttpContext httpContext
                    
                ) =>
            {

            });
        }
    }
}
