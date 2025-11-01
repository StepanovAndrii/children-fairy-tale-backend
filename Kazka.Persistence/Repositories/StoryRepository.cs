using Domain.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class StoryRepository: Repository<Story>, IStoryRepository
    {
        public StoryRepository(KazkaContext context): base(context)
        {
            
        }

        public async Task<Chapter?> GetChapterByIdAsync(int chapterId)
        {
            return await _context.Chapters
                .Include(chapter => chapter.Paragraphs)
                .Include(chapter => chapter.Audio)
                .AsNoTracking()
                .FirstOrDefaultAsync(chapter => chapter.Id == chapterId);
        }
    }
}
