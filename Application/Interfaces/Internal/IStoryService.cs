using Application.Features.Commands;
using Domain.Entities;

namespace Application.Interfaces.Internal
{
    public interface IStoryService
    {
        Task<Guid> CreateStoryAsync(CreateStoryCommand command);
        Task<List<Paragraph>> GetParagraphsAsync(Guid chapterId);
        Task<List<Chapter>> GetChapterSummariesAsync(Guid storyId);
        Task<List<Story>> GetStorySummariesAsync();
        Task DeleteStoryAsync(Guid id);
    }
}
