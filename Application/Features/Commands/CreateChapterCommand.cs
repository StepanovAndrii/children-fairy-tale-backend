namespace Application.Features.Commands
{
    public record CreateChapterCommand
    (
        int SequenceNumber,
        string Title,
        string? AudioUrl,
        List<CreateParagraphCommand> Paragraphs
    );
}
