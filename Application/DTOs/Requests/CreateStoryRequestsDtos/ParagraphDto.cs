namespace Application.DTOs.Requests.CreateStoryRequestsDtos
{
    public record ParagraphDto(
        short OrderNumber,
        string Text,
        string ImageUrl,
        int StartTimeMs,
        int EndTimeMs
    );
}
