using Application.Interfaces.Services;
using Kazka.Application.Features.Book.Command.Add;
using Kazka.Application.Features.Stories.Responses.Add;
using MediatR;

namespace Kazka.Application.Features.Stories.Handlers.Add
{
    public class AddStoryHandler : IRequestHandler<AddStoryCommand, AddStoryResponse>
    {
        private readonly IStoryBusinessLogic _storyBusinessLogic;
        public AddStoryHandler
            (
                IStoryBusinessLogic storyBusinessLogic
            )
        {
            _storyBusinessLogic = storyBusinessLogic;
        }
        public async Task<AddStoryResponse> Handle
            (
                AddStoryCommand request,
                CancellationToken cancellationToken
            )
        {
            var story = await _storyBusinessLogic.CreateStoryAsync(request);
            
            return new AddStoryResponse(story.Id);
        }
    }
}
