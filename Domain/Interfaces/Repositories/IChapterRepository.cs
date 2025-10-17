using Domain.Entities;

namespace Domain.Interfaces.Repositories
{
    public interface IChapterRepository
    {
        Task<Chapter?> GetChapterByIdAsync(int chapterId);
    }
}
