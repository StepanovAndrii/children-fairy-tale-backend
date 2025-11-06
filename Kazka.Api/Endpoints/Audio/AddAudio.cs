using Application.Interfaces.Services;
using Kazka.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.Chapters
{
    public class AddAudio : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapPost("story/{storyId}/chapter/{chapterId}/audio", async 
                (
                    CreateAudioRequest request,
                    [FromServices] IStoryBusinessLogic storyBusinessLogic
                ) =>
            {
                await storyBusinessLogic.CreateAudioAsync(request);
            });
        }
    }
}
