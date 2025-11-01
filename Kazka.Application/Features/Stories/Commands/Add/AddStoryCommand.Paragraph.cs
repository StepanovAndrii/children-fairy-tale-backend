namespace Kazka.Application.Features.Book.Command.Add
{
    public partial record AddStoryCommand
    {
        public record ParagraphRequest
            (
                ushort ParagraphOrder,
                string Text,
                string? ImageUrl,
                uint StartTimeMs,
                uint EndTimeMs
            );
    }
}
