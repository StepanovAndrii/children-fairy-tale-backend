using Application.DTOs.Responses;
using Domain.Entities;

namespace Application.Interfaces.Services
{
    public interface IOAuthService
    {
        UserInfoResponseDto MapToDto(User user);
        Task<User> RegisterUserAsync(
            string googleId,
            string email,
            string? profilePictureUrl = null
        );
        Task<bool> UserExistsAsync(string googleId);
        Task<User?> GetUserInfoAsync(int id);
        Task<User?> GetUserInfoAsync(string googleId);
    }
}
