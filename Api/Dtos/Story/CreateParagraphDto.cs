namespace Api.Dtos.Story
{
    public class CreateParagraphDto
    {
        public int SequenceNumber { get; set; }
        public required string Content { get; set; }
        public string? IllustrationUrl { get; set; }
        public int StartTimeInMilliseconds { get; set; }
        public int EndTimeInMilliseconds { get; set; }
    }
}
