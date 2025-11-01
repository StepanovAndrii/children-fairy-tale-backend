using Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.Stories.Get
{
    public class GetStoriesSummary: IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapGet("stories",
                async (
                    uint? CategoryId,
                    uint? Limit,
                    uint? Offset,
                    [FromServices] IStoryBusinessLogic storyBusinessLogic
                ) =>
            {
                var stories = await storyBusinessLogic.GetAllStories();

                return Results.Ok(stories);
            });
        }
    }
}
