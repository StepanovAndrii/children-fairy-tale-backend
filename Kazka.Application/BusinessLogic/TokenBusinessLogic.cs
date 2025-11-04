using Kazka.Application.BusinessLogic.Utils;
using Kazka.Core.Entities;
using Kazka.Core.Interfaces.Repositories;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Kazka.Application.BusinessLogic
{
    public class TokenBusinessLogic
    {
        private readonly IConfiguration _configuration;
        private readonly IRefreshTokenRepository _refreshTokenRepository;

        public TokenBusinessLogic(
                IConfiguration configuration,
                IRefreshTokenRepository refreshTokenRepository
            )
        {
            _configuration = configuration;
            _refreshTokenRepository = refreshTokenRepository;
        }

        public async Task<(string accessToken, string refreshToken)> GenerateTokensAsync(int userId)
        {
            var secret = _configuration["Jwt:Secret"];
            if (secret is null)
                throw new InvalidOperationException("JWT secret is not configured.");

            var key = Encoding.UTF8.GetBytes(secret);

            var tokenHandler = new JwtSecurityTokenHandler();
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim(ClaimTypes.NameIdentifier, user.Id}),
                Expires = DateTime.UtcNow.AddHours(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key),
                    SecurityAlgorithms.HmacSha256Signature)
            };
            var accessToken = tokenHandler.WriteToken(tokenHandler.CreateToken(tokenDescriptor));

            var refreshToken = TokenUtils.GenerateRefreshToken(64);
            var hashed = TokenUtils.ComputeSha256HashBase64(refreshToken);

            var entity = new RefreshToken
            {
                HashedToken = hashed,
                UserId = user.Id,
                User = user,
                Expires = DateTime.UtcNow.AddDays(30),
                IsRevoked = false,
            };

            await _refreshTokenRepository.AddAsync(entity);

            return (accessToken, refreshToken);
        }

        public async Task<string?> RefreshAccessTokenAsync(string presentedRefreshToken)
        {
            var presentedHash = TokenUtils.ComputeSha256HashBase64(presentedRefreshToken);

            var tokenEntity = await _refreshTokenRepository.GetByHashedToken(presentedHash);
            if (tokenEntity is null)
                return null;

            tokenEntity.IsRevoked = true;
            await _refreshTokenRepository.UpdateAsync(tokenEntity);

            var (newAccess, newRefresh) = await GenerateTokensAsync(tokenEntity.UserId);
            return newAccess;
        }
    }
}
