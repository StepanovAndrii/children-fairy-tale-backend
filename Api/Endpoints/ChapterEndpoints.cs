using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Api.Endpoints
{
    public static class ChapterEndpoints
    {
        public static void MapAuthEndpoints(this RouteGroupBuilder group)
        {
            var storyGroup = group.MapGroup("/chapter");

            storyGroup.MapGet("", GetChapter).RequireAuthorization();
        }

        public static async Task<IResult> GetChapter
            (
                int chapterId,
                [FromServices] IStoryService storyService
            )
        {
            return await storyService.GetChapterByIdAsync(chapterId) is { } chapter
                ? Results.Ok(chapter)
                : Results.NotFound();
        }
    }
}
