using Application.Services;

namespace Kazka.Api.Endpoints.Stories.Get
{
    public class GetChapterParagraphs : IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("stories/{storyId}/categories/{categoryId}/paragraphs",
                async (
                    uint storyId,
                    uint categoryId
                ) =>
            {
                
            });
        }
    }
}
