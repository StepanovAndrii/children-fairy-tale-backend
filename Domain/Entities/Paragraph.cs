namespace Domain.Entities
{
    public class Paragraph
    {
        public Guid Id { get; set; }
        public int SequenceNumber { get; set; }
        public required string Content { get; set; }
        public string? IllustrationUrl { get; set; }
        public int StartTimeInMilliseconds { get; set; }
        public int EndTimeInMilliseconds { get; set; }

        public Guid ChapterId { get; set; }
        public Chapter Chapter { get; set; } = null!;
    }
}
