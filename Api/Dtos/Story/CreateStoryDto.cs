namespace Api.Dtos.Story
{
    public class CreateStoryDto
    {
        public required string Title { get; set; }
        public string? Description { get; set; }
        public string? CoverImageUrl { get; set; }
        public required string LanguageCode { get; set; }
        public List<CreateChapterDto> Chapters { get; set; } = new();
    }
}
