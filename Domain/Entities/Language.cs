using Domain.ValueObjects;

namespace Domain.Entities
{
    public class Language
    {
        public int Id { get; set; }
        public required LanguageCode Code { get; set; }
        public required string Name { get; set; }
        public ICollection<Book> Books { get; set; } = new HashSet<Book>();
    }
}
