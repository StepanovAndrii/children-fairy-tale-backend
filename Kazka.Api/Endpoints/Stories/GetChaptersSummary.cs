
using Application.Services;

namespace Api.Endpoints.Stories
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
