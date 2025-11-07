namespace Domain.Entities
{
    public class Paragraph
    {
        public uint Id { get; set; }
        public ushort ParagraphOrder { get; set; }
        public required string Text { get; set; }
        public required string? ImageUrl { get; set; }
        public uint StartTimeMs { get; set; }
        public uint EndTimeMs { get; set; }
        public uint ChapterId { get; set; }
        public Chapter? Chapter { get; set; }
    }
}
