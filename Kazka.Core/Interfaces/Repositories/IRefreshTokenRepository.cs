using Kazka.Core.Entities;
using Kazka.Core.Interfaces.Repositories.Base;

namespace Kazka.Core.Interfaces.Repositories
{
    public interface IRefreshTokenRepository: IRepository<RefreshToken>
    {
        Task<RefreshToken> GetByHashedToken(string hashedToken);
    }
}
