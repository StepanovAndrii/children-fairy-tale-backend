using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Audio
    {
        public int ChapterId { get; set; }
        public required string AudioUrl { get; set; }
        public required Chapter Chapter { get; set; }
    }
}
