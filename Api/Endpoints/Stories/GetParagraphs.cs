using Application.Interfaces.Internal;

namespace Api.Endpoints.Stories
{
    public class GetParagraphs
    {
        public static void Map(WebApplication builder)
        {
            builder.MapGet(
                "/api/v1/stories/{storyId}/chapters/{chapterId}/paragraphs",
                async (
                    Guid storyId,
                    Guid chapterId,
                    IStoryService storyService
                ) =>
                {
                    var paragraphs = await storyService.GetParagraphsAsync(chapterId);

                    if (paragraphs is null || paragraphs.Count == 0)
                        return Results.NotFound();

                    return Results.Ok(paragraphs);
                }
            );
        }
    }
}
