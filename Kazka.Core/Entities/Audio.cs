using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Audio
    {
        public uint ChapterId { get; set; }
        public required Url AudioUrl { get; set; }
        public required Chapter Chapter { get; set; }
    }
}
