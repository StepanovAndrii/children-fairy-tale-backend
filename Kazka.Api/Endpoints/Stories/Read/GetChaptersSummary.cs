using Application.Services;

namespace Kazka.Api.Endpoints.Stories.Get
{
    public class GetChaptersSummary: IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("stories/{storyId}/categories",
                async (
                    uint storyId
                ) =>
            {
               
            });
        }
    }
}
