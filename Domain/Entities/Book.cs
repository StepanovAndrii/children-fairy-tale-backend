namespace Domain.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? CoverPath { get; set; }
        public short LanguageCode { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public DateTime UpdatedAt { get; set; } = DateTime.UtcNow;
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
        ICollection<Chapter> Chapters { get; set; } = new HashSet<Chapter>();
    }
}
