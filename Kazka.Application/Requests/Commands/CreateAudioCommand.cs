namespace Kazka.Application.Requests.Commands
{
    public class CreateAudioCommand
    {
        public required int ChapterId { get; set; }
        public required string AudioPath { get; set; }
    }
}
