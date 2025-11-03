
using Kazka.Api.DTOs.Story.Requests.UpdateStory;
using MapsterMapper;
using MediatR;

namespace Kazka.Api.Endpoints.Stories.Update
{
    public class UpdateStory : IEndpoint
    {
        public void Map(IEndpointRouteBuilder app)
        {
            app.MapPatch("stories/{id}", async (
                    UpdateStoryRequestDto dto,
                    ISender mediator,
                    IMapper mapper
                ) =>
            {
                var command = d
            });
        }
    }
}
