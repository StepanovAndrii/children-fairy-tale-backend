using Kazka.Application.Features.Stories.Commands.Update;
using Kazka.Application.Features.Stories.Responses.Update;
using MediatR;

namespace Kazka.Application.Features.Stories.Handlers.Update
{
    public class UpdateStoryHandler : IRequestHandler<UpdateStoryCommand, UpdateStoryResponse>
    {
        public Task<UpdateStoryResponse> Handle(UpdateStoryCommand request, CancellationToken cancellationToken)
        {
            
        }
    }
}
