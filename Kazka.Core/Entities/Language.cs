using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Language
    {
        public uint Id { get; set; }
        public required LanguageCode Code { get; set; }
        public ICollection<Story> Books { get; set; } = new HashSet<Story>();
    }
}
