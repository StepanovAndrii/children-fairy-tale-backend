using Kazka.Core.Entities;
using Kazka.Core.Interfaces.Repositories;
using Kazka.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Kazka.Persistence.Repositories
{
    public class RefreshTokenRepository : Repository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository
            (
                KazkaContext context
            ): base(context)
        {
           
        }
        public async Task<RefreshToken?> GetByHashedTokenAsync
            (
                string hashedToken
            )
        {
            return await _context
                .RefreshTokens
                .AsNoTracking()
                .FirstOrDefaultAsync(refreshToken => refreshToken.HashedToken == hashedToken);
        }
    }
}
