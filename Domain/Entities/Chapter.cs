namespace Domain.Entities
{
    public class Chapter
    {
        public Guid Id { get; set; }
        public int SequenceNumber { get; set; }
        public required string Title { get; set; }
        public string? AudioUrl { get; set; }

        public ICollection<Paragraph> Paragraphs { get; set; } = new List<Paragraph>();

        public Guid StoryId { get; set; }
        public Story Story { get; set; } = null!;
    }
}
