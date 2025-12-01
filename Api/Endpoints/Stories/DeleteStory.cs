using Application.Interfaces.Internal;

namespace Api.Endpoints.Stories
{
    public static class DeleteStory
    {
        public static void Map(WebApplication builder)
        {
            builder.MapDelete(
                "/api/v1/stories/{storyId}",
                async (
                    Guid storyId,
                    IStoryService storyService
                ) =>
                {
                    await storyService.DeleteStoryAsync(storyId);
                    return Results.NoContent();
                }
            );
        }

    }
}
