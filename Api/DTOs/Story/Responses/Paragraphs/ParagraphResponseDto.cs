namespace Api.DTOs.Story.Responses.Paragraphs
{
    public record ParagraphResponseDto
        (
            ushort OrderNumber,
            string Text,
            string ImageUrl,
            uint StartTimeMs,
            uint EndTimeMs
        );
}
