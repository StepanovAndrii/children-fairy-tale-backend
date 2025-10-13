using Domain.ValueObjects;

namespace Domain.Entities
{
    public class User
    {
        public int Id { get; set; }
        public required string GoogleId { get; set; }
        public required Email Email { get; set; }
        public required string NormalizedEmail { get; set; }
        public Url? ProfilePictureUrl { get; set; }
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
    }
}
