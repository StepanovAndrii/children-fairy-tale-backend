namespace Api.DTOs.Story.Requests.CreateStory
{
    public record CreateChapterRequestDto
        (
            ushort Order,
            string Title,
            string AudioUrl,
            List<CreateParagraphRequestDto> Paragraphs
        );
}
