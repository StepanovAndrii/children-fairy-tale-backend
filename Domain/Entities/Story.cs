using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Story
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public required Category Category { get; set; }
        public Url? CoverPath { get; set; }
        public int LanguageId { get; set; }
        public required Language Language { get; set; }
        public DateTime CreatedAt { get; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
        public ICollection<Chapter> Chapters { get; set; } = new HashSet<Chapter>();
    }
}
