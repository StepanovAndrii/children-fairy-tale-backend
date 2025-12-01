namespace Domain.Entities
{
    public class Story
    {
        public Guid Id { get; set; }
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? CoverImageUrl { get; set; }

        public required string LanguageCode { get; set; }

        public ICollection<Chapter> Chapters { get; set; } = new List<Chapter>();
    }
}
