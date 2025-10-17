using Application.DTOs.Requests.CreateStoryRequestsDtos;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IStoryService
    {
        Task<IEnumerable<Story>> GetStoriesAsync
            (
                int? offset = null,
                int? limit = null,
                int? categoryId = null
            );

        Task<Story?> GetStoryByIdAsync(int storyId);
        Task<Chapter?> GetChapterByIdAsync(int chapterId);
        Task<Story> CreateStoryAsync(StoryCreateDto storydto);
        Task DeleteStoryAsync(int storyId);
    }
}
