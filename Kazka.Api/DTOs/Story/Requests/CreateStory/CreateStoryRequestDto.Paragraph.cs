namespace Api.DTOs.Story.Requests.CreateStory
{
    public partial record CreateStoryRequestDto
    {
        public record ParagraphDto
        (
            ushort ParagraphOrder,
            string Text,
            string? ImageUrl,
            uint StartTimeMs,
            uint EndTimeMs
        );
    }
}
