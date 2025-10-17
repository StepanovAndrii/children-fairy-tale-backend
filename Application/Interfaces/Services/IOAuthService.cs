using Application.DTOs.Responses;
using Domain.Entities;
using Domain.Interfaces.Repositories;

namespace Application.Interfaces.Services
{
    public interface IOAuthService
    {
        Task<User> RegisterUserAsync(
            string googleId,
            string email,
            string? profilePictureUrl = null
        );
        Task<bool> UserExistsAsync(string googleId);
        Task<User?> GetUserInfoAsync(int id);
        Task<User?> GetUserInfoAsync(string googleId);
        Task UpdateUserAsync(User user);
    }
}
