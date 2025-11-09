
using Application.Interfaces.Services;
using Kazka.Api.Attributes;
using Kazka.Api.Dtos.Requests;
using Kazka.Api.Dtos.Responces;
using Kazka.Api.Extensions;
using Kazka.Application.Requests.Commands;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Chapters
{
    [EndpointVersion(1)]
    public class UpdateAudio : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapPatch
                (
                    "/stories/{storyId}/chapter/{chapterId}/audio",
                    async 
                        (
                            [FromServices] IStoryBusinessLogic storyBusinessLogic,
                            UpdateAudioRequest request,
                            int storyId,
                            int chapterId
                        ) =>
                    {
                        var command = new UpdateAudioCommand
                        {
                            ChapterId = chapterId,
                            AudioPath = request.AudioPath
                        };

                        var result = await storyBusinessLogic.UpdateAudioAsync(command);

                        return result.ToActionResult(audio => 
                            new AudioResponce 
                            {
                                ChapterId = chapterId,
                                AudioPath = request.AudioPath,
                            });
                    }
                );
        }
    }
}
