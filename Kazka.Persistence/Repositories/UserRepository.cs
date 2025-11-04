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
        public async Task<User?> GetByGoogleIdAsync(
                string googleId
            )
            => await _context.Users
                .AsNoTracking()
                .SingleOrDefaultAsync(user => user.GoogleId == googleId);
    }
}
