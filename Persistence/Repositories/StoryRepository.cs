using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class StoryRepository : IStoryRepository
    {
        private readonly KazkaDbContext _context;
        public StoryRepository(KazkaDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Story>> GetStoriesAsync(
            int? limit = null,
            int? offset = null,
            int? categoryId = null)
        {
            var query = _context.Stories.AsQueryable();

            if (categoryId.HasValue)
                query = query.Where(s => s.CategoryId == categoryId);

            if (offset.HasValue)
                query = query.Skip(offset.Value);

            if (limit.HasValue)
                query = query.Take(limit.Value);

            return await query
                .Include(story => story.Likes)
                .ToListAsync();
        }

        public async Task<Story?> GetStoryByIdAsync(int storyId)
        {
            return await _context.Stories
                .Include(s => s.Chapters)
                .AsNoTracking()
                .FirstOrDefaultAsync(s => s.Id == storyId);
        }

        public async Task<Story> CreateStoryAsync(Story story)
        {
            var storyEntity = await _context.Stories.AddAsync(story);
            await _context.SaveChangesAsync();

            return storyEntity.Entity;
        }

        public void DeleteStory(Story story)
        {
            _context.Stories.Remove(story);
            _context.SaveChanges();
        }

        public async Task<Category> CreateCategoryAsync(Category category)
        {
            var categoryEntity = await _context.Categories.AddAsync(category);
            await _context.SaveChangesAsync();
            return categoryEntity.Entity;
        }

        public async Task HardDeleteCategory(Category category)
        {
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public async Task<bool> CategoryExistsByNameAsync(string categoryName)
        {
            return await _context.Categories
                .AsNoTracking()
                .AnyAsync(c => c.Name == categoryName);
        }

        public Task<Category?> GetCategoryByNameAsync(string categoryName)
        {
            return _context.Categories
                .AsNoTracking()
                .SingleOrDefaultAsync(c => c.Name == categoryName);
        }
    }
}
