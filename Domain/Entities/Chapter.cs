namespace Domain.Entities
{
    public class Chapter
    {
        public int Id { get; set; }
        public short Number { get; set; }
        public Audio? Audio { get; set; }
        public int BookId { get; set; }
        public Story? Book { get; set; }
        public ICollection<Paragraph> Paragraphs { get; set; } = new HashSet<Paragraph>();
    }
}
