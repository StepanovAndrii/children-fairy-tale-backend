using Kazka.Core.Entities;

namespace Domain.Entities
{
    public class Story
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public string? Description { get; set; }
        public string? CoverPath { get; set; }
        public int LanguageId { get; set; }
        public Language Language { get; set; } = null!;
        public DateTime UpdatedAt { get; set; }
        public ICollection<StoryCategory> StoryCategories { get; set; } = new HashSet<StoryCategory>();
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
        public ICollection<Chapter> Chapters { get; set; } = new HashSet<Chapter>();
    }
}
