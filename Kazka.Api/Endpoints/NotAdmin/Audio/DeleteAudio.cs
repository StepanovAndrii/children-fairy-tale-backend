using Application.Interfaces.Services;
using Kazka.Api.Attributes;
using Kazka.Api.Extensions;
using Kazka.Application.Requests.Commands;
using Kazka.Core;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Chapters
{
    [EndpointVersion(1)]
    public class DeleteAudio : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapDelete("/stories/{storyId}/chapter/{chapterId}/audio", 
                async (
                    [FromServices] IStoryBusinessLogic storyBusinessLogic,
                    int storyId,
                    int chapterId
                ) =>
            {
                var command = new DeleteAudioCommand
                {
                    ChapterId = chapterId
                };

                var result = await storyBusinessLogic.DeleteAudioAsync(command);

                return result.ToActionResult<Unit, Unit>();
            });
        }
    }
}
