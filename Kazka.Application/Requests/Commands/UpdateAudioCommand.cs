namespace Kazka.Application.Requests.Commands
{
    public class UpdateAudioCommand
    {
        public required int ChapterId { get; set; }
        public string? AudioPath { get; set; }
    }
}
