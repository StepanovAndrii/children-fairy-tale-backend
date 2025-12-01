using Application.Interfaces.Internal;

namespace Api.Endpoints.Stories
{
    public static class GetChaptersSummary
    {
        public static void Map(WebApplication builder)
        {
            builder.MapGet(
                "/api/v1/stories/{storyId}/chapters",
                async (
                    Guid storyId,
                    IStoryService storyService
                ) =>
                {
                    var chapters = await storyService.GetChapterSummariesAsync(storyId);

                    if (chapters is null || chapters.Count == 0)
                        return Results.NotFound();

                    return Results.Ok(chapters);
                }
            );
        }
    }
}
