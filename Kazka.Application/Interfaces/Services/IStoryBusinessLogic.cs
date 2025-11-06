using Domain.Entities;
using Kazka.Application.DTOs;

namespace Application.Interfaces.Services
{
    public interface IStoryBusinessLogic
    {
        Task<IEnumerable<Story>> GetAllStories();
        Task<Story> CreateStoryAsync();
        Task<Audio> CreateAudioAsync(CreateAudioRequest request);
    }
}
