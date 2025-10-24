namespace Api.DTOs.Story.Requests.CreateStory
{
    public record CreateParagraphRequestDto
        (
            ushort OrderNumber,
            string Text,
            string? ImageUrl,
            uint StartTimeMs,
            uint EndTimeMs
        );
}
