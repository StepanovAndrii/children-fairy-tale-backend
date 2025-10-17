using Domain.Entities;
using Domain.Interfaces.Repositories;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;
using System.Threading.Tasks;

namespace Persistence.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly KazkaDbContext _context;
        public UserRepository(KazkaDbContext context)
        {
            _context = context;
        }
        
        public async Task AddAsync(User user)
        {
            await _context.Users.AddAsync(user);
            await _context.SaveChangesAsync();
        }
        
        public async Task<User?> GetByGoogleIdAsync(string googleId)
            => await _context
                .Users
                .AsNoTracking()
                .SingleOrDefaultAsync(user => user.GoogleId == googleId);

        public async Task<User?> GetByIdAsync(int id)
            => await _context
                .Users
                .FindAsync(id);
         public async Task<bool> ExistsByIdAsync(int id)
            => await _context
                .Users
                .AsNoTracking()
                .AnyAsync(user => user.Id == id);
        public async Task<bool> ExistsByGoogleIdAsync(string googleId)
            => await _context
                .Users
                .AsNoTracking()
                .AnyAsync(user => user.GoogleId == googleId);

        public async Task UpdateAsync(User user)
        {
            _context.Users.Update(user);
            await _context.SaveChangesAsync();
        }

        public async Task HardDeleteAsync(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }
    }
}
