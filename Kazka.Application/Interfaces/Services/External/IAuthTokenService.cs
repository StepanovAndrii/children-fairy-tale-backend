using Domain.Entities;
using System.Security.Cryptography;

namespace Kazka.Application.Interfaces.Services.External
{
    public interface IAuthTokenService
    {
        (string jwtToken, DateTime expiresAtUtc) GenerateJwtToken(User user);
        string GenerateRefreshToken();
        void WriteAuthTokenAsHttpOnlyCookie
            (
                string cookieName,
                string token,
                DateTime expiration
            );
        string HashRefreshToken(string refreshToken);
    }
}
