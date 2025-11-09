using Domain.Enums;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string GoogleId { get; set; }
        public UserRole Role { get; set; }
        public byte? Age { get; set; }
        public required string Name { get; set; }
        public required string Email { get; set; }
        public required string NormalizedEmail { get; set; }
        public string? ProfilePictureUrl { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
    }
}
