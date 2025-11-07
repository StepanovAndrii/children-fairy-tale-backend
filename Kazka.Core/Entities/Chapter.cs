namespace Domain.Entities
{
    public class Chapter
    {
        public uint Id { get; set; }
        public short Order { get; set; }
        public required string Title { get; set; }
        public Audio? Audio { get; set; }
        public uint StoryId { get; set; }
        public Story? Story { get; set; }
        public ICollection<Paragraph> Paragraphs { get; set; } = new HashSet<Paragraph>();
    }
}
