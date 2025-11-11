using Domain.Enums;
using System.Security.Claims;

namespace Kazka.Application.Interfaces.External
{
    public interface ITokenService
    {
        string GenerateAccessToken(int userId, string email, UserRole role);
        string GenerateRefreshToken();
        string HashToken(string token);
        ClaimsPrincipal GetPrincipalFromExpiredToken(string token);
    }
}
