using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class ChapterRepository : IChapterRepository
    {
        private readonly KazkaDbContext _context;
        public ChapterRepository(KazkaDbContext context)
        {
            _context = context;
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
