namespace Domain.Entities
{
    public class Chapter
    {
        public uint Id { get; set; }
        public short Order { get; set; }
        public required string Title { get; set; }
        public Audio? Audio { get; set; }
        public uint BookId { get; set; }
        public Story? Book { get; set; }
        public ICollection<Paragraph> Paragraphs { get; set; } = new HashSet<Paragraph>();
    }
}
