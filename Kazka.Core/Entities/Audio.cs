namespace Domain.Entities
{
    public class Audio
    {
        public int ChapterId { get; set; }
        public required string AudioPath { get; set; }
        public required Chapter Chapter { get; set; }
    }
}
