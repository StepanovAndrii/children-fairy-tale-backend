using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Paragraph
    {
        public int Id { get; set; }
        public short OrderNumber { get; set; }
        public required string Text { get; set; }
        public required Url ImageUrl { get; set; }
        public int StartTimeMs { get; set; }
        public int EndTimeMs { get; set; }
        public int ChapterId { get; set; }
        public Chapter? Chapter { get; set; }
    }
}
