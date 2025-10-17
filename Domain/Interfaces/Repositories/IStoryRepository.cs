using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IStoryRepository
    {
        Task<IEnumerable<Story>> GetStoriesAsync(int? limit = null, int? offset = null, int? categoryId = null);
        Task<Story?> GetStoryByIdAsync(int storyId);
        Task<Story> CreateStoryAsync(Story story);
        Task<Category> CreateCategoryAsync(Category category);
        Task HardDeleteCategory(Category category);
        void DeleteStory(Story story);
        Task<bool> CategoryExistsByNameAsync(string categoryName);
        Task<Category?> GetCategoryByNameAsync(string categoryName);
    }
}
