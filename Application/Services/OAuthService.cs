using Application.DTOs.Responses;
using Application.Interfaces.Services;
using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.ValueObjects;

namespace Application.Services
{
    public class OAuthService : IOAuthService
    {
        private readonly IUserRepository _userRepository;

        public OAuthService(
            IUserRepository userRepository,
            Interfaces.IMapper mapper
        )
        {
            _userRepository = userRepository;
        }

        public async Task<User> RegisterUserAsync(
            string googleId,
            string email,
            string? profilePictureUrl = null
        )
        {
            var existingUser = await GetUserInfoAsync(googleId);

            if (existingUser != null)
                return existingUser;

            var emailVO = new Email(email);
            Url? profilePictureVO = null;

            if (!string.IsNullOrWhiteSpace(profilePictureUrl))
                profilePictureVO = new Url(profilePictureUrl);

            var user = new User
            {
                GoogleId = googleId,
                Name = $"user{Guid.NewGuid().ToString()[..8]}",
                Email = emailVO,
                NormalizedEmail = emailVO.Normalized,
                ProfilePictureUrl = profilePictureVO
            };

            await _userRepository.AddAsync(user);
            return user;
        }
        public async Task<bool> UserExistsAsync(string googleId)
        {
            return await _userRepository.ExistsByGoogleIdAsync(googleId);
        }
        public async Task<User?> GetUserInfoAsync(int id)
        {
            return await _userRepository.GetByIdAsync(id);
        }

        public async Task<User?> GetUserInfoAsync(string googleId)
        {
            return await _userRepository.GetByGoogleIdAsync(googleId);
        }

        public async Task UpdateUserAsync(User user)
        {
            await _userRepository.UpdateAsync(user);
        }
    }
}
