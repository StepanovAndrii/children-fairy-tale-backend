namespace Api.Dtos.Story
{
    public class CreateChapterDto
    {
        public int SequenceNumber { get; set; }
        public required string Title { get; set; }
        public string? AudioUrl { get; set; }
        public List<CreateParagraphDto> Paragraphs { get; set; } = new();
    }
}
