using Kazka.Core.Entities;

namespace Domain.Entities
{
    public class Story
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? CoverPath { get; set; }
        public int LanguageId { get; set; }
        public required Language Language { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
        public ICollection<Chapter> Chapters { get; set; } = new HashSet<Chapter>();
        public ICollection<StoryCategory> StoryCategories { get; set; } = new HashSet<StoryCategory>();
    }
}
