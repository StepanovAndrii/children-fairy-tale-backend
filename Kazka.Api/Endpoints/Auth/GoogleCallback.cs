
namespace Kazka.Api.Endpoints.Auth
{
    public class GoogleCallback : IEndpoint
    {
        public void Map(
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("")
        }
    }
}
