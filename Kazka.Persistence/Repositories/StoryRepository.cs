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
    }
}
