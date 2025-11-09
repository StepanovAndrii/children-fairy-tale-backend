using Kazka.Core.Interfaces.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Kazka.Persistence.Repositories.Base
{
    public class Repository<T>: IRepository<T> where T: class
    {
        protected readonly KazkaContext _context;
        public Repository(KazkaContext context)
        {
            _context = context;
        }
        public async Task<T> AddAsync(T entity)
        {
            await _context
                .Set<T>()
                .AddAsync(entity);
            await _context
                .SaveChangesAsync();
            return entity;
        }

        public async Task DeleteAsync(T entity)
        {
            _context
                .Set<T>()
                .Remove(entity);
            await _context
                .SaveChangesAsync();
        }

        public async Task<List<T>> GetAllAsync()
        {
            return await _context
                .Set<T>()
                .AsNoTracking()
                .ToListAsync();
        }

        public async Task<T?> GetByIdAsync(int id)
        {
            return await _context
                .Set<T>()
                .FindAsync(id);
        }

        public async Task UpdateAsync(T entity)
        {
            _context
                .Set<T>()
                .Update(entity);
            await _context
                .SaveChangesAsync();
        }
    }
}
