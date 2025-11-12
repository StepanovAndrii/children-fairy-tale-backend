using Domain.Enums;
using Kazka.Core.Entities;
using Microsoft.AspNetCore.Identity;

namespace Domain.Entities
{
    public class User: IdentityUser<int>
    {
        public required string GoogleId { get; set; }
        public UserRole Role { get; set; }
        public byte? Age { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
    }
}
