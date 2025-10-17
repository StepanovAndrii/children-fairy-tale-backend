using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Audio
    {
        public int ChapterId { get; set; }
        public required Url AudioUrl { get; set; }
        public Chapter? Chapter { get; set; }
    }
}
