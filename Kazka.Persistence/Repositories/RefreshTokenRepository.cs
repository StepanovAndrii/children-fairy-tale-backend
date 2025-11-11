using Kazka.Core.Entities;
using Kazka.Core.Interfaces.Repositories;
using Kazka.Persistence.Repositories.Base;
using Persistence.Contexts;

namespace Kazka.Persistence.Repositories
{
    public class RefreshTokenRepository: Repository<RefreshToken>, IRefreshTokenRepository
    {
        public RefreshTokenRepository(KazkaContext context): base(context)
        {
            
        }
    }
}
