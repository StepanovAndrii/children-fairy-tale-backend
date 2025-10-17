using Application.DTOs.Requests;
using Application.DTOs.Requests.CreateStoryRequestsDtos;
using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using Persistence.Contexts;

namespace Api.Endpoints
{
    public static class StoryEndpoints
    {
        public static void MapAuthEndpoints(this RouteGroupBuilder group)
        {
            var storyGroup = group.MapGroup("/stories");

            storyGroup.MapGet("", GetStories).RequireAuthorization();
            storyGroup.MapGet("/{story_id:int}", GetStory).RequireAuthorization();
            storyGroup.MapPost("", CreateStory);
            storyGroup.MapDelete("/{story_id:int}", DeleteStory).RequireAuthorization(
                "AdminOnly"
            );
        }

        private static async Task<IResult> DeleteStory(
                int story_id,
                [FromServices] IStoryService storyService
            )
        {
            try
            {
                await storyService.DeleteStoryAsync(story_id);
                return Results.Ok(new { message = "Story deleted successfully." });
            }
            catch (KeyNotFoundException)
            {
                return Results.NotFound(new { message = "Story not found." });
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }

        private static async Task<IResult> GetStories(
                [AsParameters] StoryQueryParameters queryParameters,
                [FromServices] IStoryService storyService
            )
        {
            var stories = await storyService.GetStoriesAsync(
                queryParameters.Limit,
                queryParameters.Offset,
                queryParameters.CategoryId
            );

            return Results.Ok(stories);
        }

        private static IResult GetStory(
                int story_id,
                [FromServices] IStoryService storyService
            )
        {
            var story = storyService.GetStoryByIdAsync(story_id);

            return story is null
                ? Results.NotFound()
                : Results.Ok(story);
        }

        private static async Task<IResult> CreateStory(
                StoryCreateDto dto,
                [FromServices] KazkaDbContext context,
                [FromServices] IStoryService storyService
            )
        {
            try
            {
                return Results.Ok(await storyService.CreateStoryAsync(dto));
            }
            catch (Exception ex)
            {
                return Results.Problem(ex.Message);
            }
        }
    }
}
