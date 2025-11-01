using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Story
    {
        public uint Id { get; private set; }
        public string Title { get; private set; } = null!;
        public string? Description { get; private set; }
        public uint CategoryId { get; private set; }
        public Category Category { get; private set; } = null!;
        public Url? CoverPath { get; private set; }
        public uint LanguageId { get; private set; }
        public Language Language { get; private set; } = null!;
        public DateTime CreatedAt { get; private set; }
        public DateTime UpdatedAt { get; private set; }
        public ICollection<Like> Likes { get; set; } = new HashSet<Like>();
        public ICollection<Chapter> Chapters { get; set; } = new HashSet<Chapter>();

        private Story() { }

        public static Story Create
            (
                string title,
                Category category,
                Language language,
                string? description = null,
                Url? coverPath = null
            )
        {
            //if (string.IsNullOrWhiteSpace(title))
                // TODO: add result object

            var story = new Story
            {
                Title = title,
                Description = description,
                CoverPath = coverPath,
                LanguageId = language.Id,
                Language = language,
                Category = category,
                CategoryId = category.Id,
                CreatedAt = DateTime.UtcNow,
                UpdatedAt = DateTime.UtcNow,
            };

            return story;
        }

        public void UpdateDetails
            (
                string? title = null,
                string? description = null,
                Url? coverPath = null
            )
        {
            if (!string.IsNullOrWhiteSpace(title))
                Title = title;

            if (!string.IsNullOrWhiteSpace(description))
                Description = description;

            if (coverPath != null)
                CoverPath = coverPath;

            Touch();
        }

        public void AddChapter(Chapter chapter)
        {
            Chapters.Add(chapter);
            Touch();
        }

        private void Touch() => UpdatedAt = DateTime.UtcNow;
    }
}
