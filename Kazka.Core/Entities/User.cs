using Domain.Enums;
using Kazka.Core.Entities;
namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string GoogleId { get; set; }
        public UserRole Role { get; set; }
        public int? Age { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string NormalizedEmail { get; set; }
        public required string ProfilePictureUrl { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<RefreshToken> RefreshTokens { get; set; } = new HashSet<RefreshToken>();
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
    }
}
