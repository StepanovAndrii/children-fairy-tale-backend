using Application.Interfaces.Services;
using Domain.Entities;
using Kazka.Api.Attributes;
using Kazka.Api.Dtos.Requests;
using Kazka.Api.Extensions;
using Kazka.Application.Requests.Commands;
using Kazka.Core;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Chapters
{
    [EndpointVersion(1)]
    public class CreateAudio : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapPost("/stories/{storyId}/chapter/{chapterId}/audio", async 
                (
                    [FromBody] CreateAudioRequest request,
                    IStoryBusinessLogic storyBusinessLogic,
                    int storyId,
                    int chapterId
                ) =>
            {
                var command = new CreateAudioCommand
                {
                    ChapterId = chapterId,
                    AudioPath = request.AudioPath
                };

                var result = await storyBusinessLogic.CreateAudioAsync(command);

                if (result.IsFailure)
                    result.ToActionResult<Audio, Unit>();

                return Results.Created($"/stories/{storyId}/chapter/{chapterId}/audio", null);
            });
        }
    }
}
