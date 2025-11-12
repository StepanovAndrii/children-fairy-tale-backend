using Domain.Entities;
using Kazka.Application.Interfaces.Services.External;
using Kazka.Core.Exceptions;
using Microsoft.AspNetCore.Identity;
using Domain.Enums;
using Kazka.Core.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Application.Interfaces.Services;
using System.Security.Claims;

namespace Kazka.Application.BusinessLogic
{
    public class AccountBusinessLogic: IAccountBusinessLogic
    {
        private readonly IAuthTokenService _authTokenService;
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _userRepository;

        public AccountBusinessLogic
            (
                IAuthTokenService authTokenService,
                UserManager<User> userManager,
                IUserRepository userRepository
            )
        {
            _authTokenService = authTokenService;
            _userManager = userManager;
            _userRepository = userRepository;
        }

        public async Task<string> LoginWithGoogleAsync(ClaimsPrincipal? claimsPrincipal)
        {
            if (claimsPrincipal is null)
                throw new ExternalLoginProviderException("Google", "ClaimPrincipal is null");

            var googleId = claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier);
            if (googleId is null)
                throw new ExternalLoginProviderException("Google", "Google id is null");

            var user = await _userRepository.GetByGoogleIdAsync(googleId);
            var email = claimsPrincipal.FindFirstValue(ClaimTypes.Email);
            if (user is null)
            {
                user = new User
                {
                    GoogleId = claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier),
                    Role = UserRole.User,
                    UserName = email.Split('@')[0],
                    Email = email,
                    EmailConfirmed = true,
                    UpdatedAt = DateTime.UtcNow,
                    ProfilePictureUrl = claimsPrincipal.FindFirst("picture")?.Value
                };

                var result = await _userManager.CreateAsync(user);

                if (!result.Succeeded)
                    throw new ExternalLoginProviderException(
                        "Google", $"Unable to create user: {string.Join(", ", result.Errors.Select(x => x.Description))}"
                    );
            }

            var info = new UserLoginInfo("Google",
                claimsPrincipal.FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty,
                "Google");

            var loginResult = await _userManager.AddLoginAsync(user, info);
            if (!loginResult.Succeeded)
                throw new ExternalLoginProviderException("Google",
                    $"Unable to create user: {string.Join(", ",
                        loginResult.Errors.Select(x => x.Description))}");

            var (jwtToken, expirationDateTimeInUtc) = _authTokenService.GenerateJwtToken(user);
            var refreshTokenValue = _authTokenService.GenerateRefreshToken();

            var refreshTokenExpirationDateInUtc = DateTime.UtcNow.AddDays(7);

            var hashedRefreshToken = _authTokenService.HashRefreshToken(refreshTokenValue);

            user.RefreshTokens.Add(
                new RefreshToken
                {
                    UserId = user.Id,
                    HashedToken = hashedRefreshToken,
                    ExpiresAt = expirationDateTimeInUtc,
                    IsRevoked = false
                }
            );

            await _userManager.UpdateAsync(user);

            _authTokenService.WriteAuthTokenAsHttpOnlyCookie("REFRESH_TOKEN", refreshTokenValue, refreshTokenExpirationDateInUtc);

            return jwtToken;
        }

        public async Task<string> RefreshTokenAsync(string? refreshToken)
        {
            if (string.IsNullOrEmpty(refreshToken))
                throw new RefreshTokenException("Refresh token us missing.");

            var hashedRefreshToken = _authTokenService.HashRefreshToken(refreshToken);

            var user = await _userRepository.GetUserByRefreshTokenAsync(
                hashedRefreshToken
            );

            if (user == null)
                throw new RefreshTokenException("Unable to retrieve user for refresh token.");

            var storedRefreshToken = user.RefreshTokens
                .FirstOrDefault(rt => rt.HashedToken == hashedRefreshToken);

            if (storedRefreshToken!.ExpiresAt < DateTime.UtcNow)
                throw new RefreshTokenException("Refresh token is expired.");

            var (jwtToken, expirationDateTimeInUtc) = _authTokenService.GenerateJwtToken(user);
            var refreshTokenValue = _authTokenService.GenerateRefreshToken();

            var refreshTokenExpirationDateInUtc = DateTime.UtcNow.AddDays(7);

            user.RefreshTokens.Remove(storedRefreshToken!);
            user.RefreshTokens.Add(
                new RefreshToken
                {
                    UserId = user.Id,
                    HashedToken = hashedRefreshToken,
                    ExpiresAt = expirationDateTimeInUtc,
                    IsRevoked = false
                }
            );

            await _userManager.UpdateAsync(user);

            _authTokenService.WriteAuthTokenAsHttpOnlyCookie("REFRESH_TOKEN", refreshTokenValue, refreshTokenExpirationDateInUtc);

            return jwtToken;
        }
    }
}
