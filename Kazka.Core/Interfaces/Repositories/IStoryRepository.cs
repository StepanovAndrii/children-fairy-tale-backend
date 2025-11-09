using Domain.Entities;
using Kazka.Core.Interfaces.Repositories.Base;

namespace Domain.Interfaces.Repositories
{
    public interface IStoryRepository: IRepository<Story>
    {
        Task<Chapter?> GetChapterByIdAsync(int id);
        Task DeleteAudioAsync(int chapterId);
        Task<Audio> AddAudioAsync
            (
                Audio audio
            );
        Task<Audio?> GetAudioAsync(int chapterId);
        Task UpdateAudioAsync(Audio audio);
    }
}
