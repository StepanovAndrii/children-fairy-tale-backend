namespace Domain.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public short OrderNumber { get; set; }
        public Audio? Audio { get; set; }
        public required Book Book { get; set; }
        public ICollection<Paragraph> Paragraphs { get; set; } = new HashSet<Paragraph>();
    }
}
