namespace Application.DTOs.Requests.CreateStoryRequestsDtos
{
    public record ChapterDto(
        short Number,
        AudioDto? Audio,
        List<ParagraphDto> Paragraphs
    );
}
