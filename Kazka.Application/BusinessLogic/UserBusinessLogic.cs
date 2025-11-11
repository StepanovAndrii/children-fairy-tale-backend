using Domain.Entities;
using Domain.Enums;
using Domain.Interfaces.Repositories;
using Kazka.Application.Interfaces.External;
using Kazka.Application.Interfaces.Services;
using Kazka.Application.Requests.Commands;
using Kazka.Application.Results;
using Kazka.Core.Entities;
using System.Security.Claims;

namespace Kazka.Application.BusinessLogic
{
    public class UserBusinessLogic : IUserBusinessLogic
    {
        private readonly IUserRepository _userRepository;
        private readonly ITokenService _tokenService;
        public UserBusinessLogic
            (
                ICurrentUserService currentUserService,
                IUserRepository userRepository,
                ITokenService tokenService
            )
        {
            _userRepository = userRepository;
            _tokenService = tokenService;
        }

        public async Task<Result<(string AccessToken, string RefreshToken)>> AuthenticateUserWithGoogleAsync
            (
                ClaimsPrincipal claimsPrincipal
            )
        {
            if (claimsPrincipal is null
                || !claimsPrincipal.Identity!.IsAuthenticated)
                return Result<(string AccessToken, string RefreshToken)>.Failure("Google authentication failed.", ErrorType.Unauthorized);

            var googleId = claimsPrincipal.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            if (googleId is null)
                return Result<(string AccessToken, string RefreshToken)>
                    .Failure("Google ID claim is missing in the callback.", ErrorType.Unauthorized);

            var user = await _userRepository.GetByGoogleIdAsync(googleId);
            if (user is null)
            {
                var email = claimsPrincipal.FindFirst(ClaimTypes.Email)?.Value;
                if (email is null)
                    return Result<(string AccessToken, string RefreshToken)>
                        .Failure("Email claim not found.", ErrorType.Unauthorized);

                user = new User
                {
                    GoogleId = googleId,
                    Role = UserRole.User,
                    Email = email,
                    Name = email.Split("@")[0],
                    NormalizedEmail = email.ToLowerInvariant(),
                    ProfilePictureUrl = claimsPrincipal.FindFirst("picture")?.Value,
                    UpdatedAt = DateTime.UtcNow
                };

                await _userRepository.AddAsync(user);
            }

            // TODO: make it sepparate
            var accessToken = _tokenService.GenerateAccessToken(user.Id, user.Email, user.Role);
            var refreshTokenValue = _tokenService.GenerateRefreshToken();

            var refreshToken = new RefreshToken
            {
                UserId = user.Id,
                HashedToken = _tokenService.HashToken(refreshTokenValue),
                // TODO: The same rool is on cookie service, make it joint
                ExpiresAt = DateTime.UtcNow.AddDays(30),
                IsRevoked = false
            };

            user.RefreshTokens.Add(refreshToken);

            return Result<(string AccessToken, string RefreshToken)>.Success((accessToken, refreshTokenValue), SuccessType.Ok);
        }

        public async Task<Result<List<User>>> GetUsersAsync()
        {
            var users = await _userRepository.GetAllAsync();
            if (users.Any())
                return Result<List<User>>
                    .Failure("No users found", ErrorType.NotFound);

            return Result<List<User>>.Success(users, SuccessType.Ok);
        }

        public async Task<Result<User>> UpdateUserRoleAsync(UpdateUserRoleCommand command)
        {
            var user = await _userRepository.GetByIdAsync(command.Id);
            if (user is null)
                return Result<User>
                    .Failure($"User with ID {command.Id} was not found", ErrorType.NotFound);

            user.Role = command.Role;

            await _userRepository.UpdateAsync(user);
            return Result<User>.Success(user, SuccessType.Ok);
        }
    }
}
