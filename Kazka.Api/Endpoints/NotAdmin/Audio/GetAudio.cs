
using Application.Interfaces.Services;
using Domain.Entities;
using Kazka.Api.Attributes;
using Kazka.Api.Dtos.Responces;
using Kazka.Api.Extensions;
using Kazka.Application.Requests.Queries;
using Microsoft.AspNetCore.Mvc;

namespace Kazka.Api.Endpoints.NotAdmin.Chapters
{
    [EndpointVersion(1)]
    public class GetAudio : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapGet("/stories/{storyId}/chapter/{chapterId}/audio", async
                (
                    [FromServices] IStoryBusinessLogic storyBusinessLogic,
                    int storyId,
                    int chapterId
                ) =>
            {
                var query = new GetAudioQuery
                {
                    ChapterId = chapterId
                };

                var result = await storyBusinessLogic.GetAudioAsync(query);

                result.ToActionResult(audio =>
                    new AudioResponce
                    {
                        ChapterId = audio.ChapterId,
                        AudioPath = audio.AudioPath
                    });
            });
        }
    }
}
