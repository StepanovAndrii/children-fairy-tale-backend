namespace Application.Features.Commands
{
    public record CreateParagraphCommand
    (
        int SequenceNumber,
        string Content,
        string? IllustrationUrl,
        int StartTimeInMilliseconds,
        int EndTimeInMilliseconds
    );
}
