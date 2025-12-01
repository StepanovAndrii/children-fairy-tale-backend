using Application.Interfaces.Internal.Repositories;
using Domain.Entities;
using Infrastructure.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repositories
{
    public class StoryRepository : IStoryRepository
    {
        private readonly AppDbContext _context;
        public StoryRepository(
                AppDbContext context
            ) {
            _context = context;
        }
        public async Task AddAsync(Story story)
        {
            await _context.Stories
                .AddAsync(story);
            await _context
                .SaveChangesAsync();
        }

        public async Task DeleteAsync(Guid id)
        {
            var story = await _context.Stories
                .FindAsync(id);
            if(story is not null)
                _context.Stories.Remove(story);

            await _context
                .SaveChangesAsync(); 
        }

        public async Task<List<Story>> GetAll()
        {
            return await _context.Stories
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<List<Chapter>> GetChapterSummariesByStoryIdAsync(Guid storyId)
        {
            return _context.Chapters
                .AsNoTracking()
                .ToListAsync();
        }

        public Task<List<Paragraph>> GetParagraphsByChapterIdAsync(Guid chapterId)
        {
            return _context.Paragraphs
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task UpdateAsync(Story story)
        {
            _context.Stories
                .Update(story);
            await _context
                .SaveChangesAsync();
        }
    }
}
