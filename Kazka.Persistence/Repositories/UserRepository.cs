using Domain.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(KazkaContext context) : base(context)
        {

        }

        public async Task<bool> ExistsByGoogleIdAsync(string googleId)
        {
            try
            {
                var canConnect = await _context.Database.CanConnectAsync();
                Console.WriteLine($"DB connection: {canConnect}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"DB connection error: {ex}");
            }

            var answer = await _context.Users
                .AnyAsync(user => user.GoogleId == googleId);

            return answer;
        }

        public async Task<User?> GetByGoogleIdAsync(
                string googleId
            )
            => await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(user => user.GoogleId == googleId);
    }
}
