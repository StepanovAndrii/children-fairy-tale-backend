using Domain.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Persistence.Repositories.Base;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class StoryRepository: Repository<Story>, IStoryRepository
    {
        public StoryRepository(KazkaContext context): base(context)
        {
            
        }

        public async Task<Audio> AddAudioAsync(Audio audio)
        {
            await _context.Audios.AddAsync(audio);
            await _context.SaveChangesAsync();

            return audio;
        }

        public async Task DeleteAudioAsync(int chapterId)
        {
            var audio = await _context.Audios.FindAsync(chapterId);
            if (audio is null)
                return;

            _context.Audios.Remove(audio);
            await _context.SaveChangesAsync();
        }

        public async Task<Audio?> GetAudioAsync(int chapterId)
        {
            return await _context.Audios
                .FindAsync(chapterId);
        }

        public async Task<Chapter?> GetChapterByIdAsync(int id)
        {
            return await _context.Chapters
                .FindAsync(id);
        }

        public async Task UpdateAudioAsync(Audio audio)
        {
            _context.Audios
                .Update(audio);

            await _context.SaveChangesAsync();
        }
    }
}
