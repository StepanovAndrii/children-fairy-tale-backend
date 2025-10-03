namespace Domain.Entities
{
    public class Paragraph
    {
        public int Id { get; set; }
        public short OrderNumber { get; set; }
        public required string Text { get; set; }
        public required string ImageUrl { get; set; }
        public int StartTimeMs { get; set; }
        public int EndTimeMs { get; set; }
        public required Chapter Chapter { get; set; }
    }
}
