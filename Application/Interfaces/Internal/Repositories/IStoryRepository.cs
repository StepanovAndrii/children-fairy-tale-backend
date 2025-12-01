using Domain.Entities;

namespace Application.Interfaces.Internal.Repositories
{
    public interface IStoryRepository
    {
        Task AddAsync(Story story);
        Task<List<Chapter>> GetChapterSummariesByStoryIdAsync(Guid storyId);
        Task<List<Paragraph>> GetParagraphsByChapterIdAsync(Guid chapterId);
        Task<List<Story>> GetAll();
        Task UpdateAsync(Story story);
        Task DeleteAsync(Guid id);
    }
}
