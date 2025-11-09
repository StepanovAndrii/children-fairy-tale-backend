
using Kazka.Api.Attributes;

namespace Kazka.Api.Endpoints.NotAdmin.Likes
{
    [EndpointVersion(1)]
    public class DeleteLike : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapDelete(
                "",
                async 
                    (
                        
                    ) =>
                {

                }    
            );
        }
    }
}
