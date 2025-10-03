using Domain.ValueObjects;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required Email Email { get; set; }
        public required string Username { get; set; }
        public required string ProfilePictureUrl { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
    }
}
