using Api.DTOs.Story.Requests.CreateStory;
using Kazka.Api.Settings;
using Kazka.Application.Features.Book.Command.Add;
using MapsterMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Api.Endpoints.Stories
{
    public class CreateStory : IEndpoint
    {
        public void Map
            (
                IEndpointRouteBuilder app
            )
        {
            app.MapPost("stories",
                async(
                    [FromBody] CreateStoryRequestDto request,
                    ISender mediator,
                    IMapper mapper,
                    IOptions<ApiSettings> apiOptions
                ) =>
            {
                var command = mapper.Map<AddStoryCommand>(request);

                var result = await mediator.Send(command);

                var url = $"/{apiOptions.Value.Version}/stories/{result.Id}";
                return Results.Created
                    (
                        url,
                        result
                    );
            });
        }
    }
}
