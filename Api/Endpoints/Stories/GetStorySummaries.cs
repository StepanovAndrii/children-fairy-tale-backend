using Application.Interfaces.Internal;
using Microsoft.AspNetCore.Http.HttpResults;

namespace Api.Endpoints.Stories
{
    public static class GetStorySummaries
    {
        public static void Map(WebApplication builder)
        {
            builder.MapGet(
                "/api/v1/stories",
                async (
                    IStoryService storyService
                    ) =>
                {
                    var stories = await storyService.GetStorySummariesAsync();

                    if (stories is null || stories.Count == 0)
                        return Results.NotFound();

                    return Results.Ok(stories);
                }
            );
        }
    }
}
