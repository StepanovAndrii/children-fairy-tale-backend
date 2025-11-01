using Domain.Entities;
using Kazka.Application.Features.Book.Command.Add;

namespace Application.Interfaces.Services
{
    public interface IStoryBusinessLogic
    {
        Task<IEnumerable<Story>> GetAllStories();
        Task<Story> CreateStoryAsync(AddStoryCommand request);
    }
}
