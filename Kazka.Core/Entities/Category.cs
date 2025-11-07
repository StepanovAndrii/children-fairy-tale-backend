using Kazka.Core.Entities;

namespace Domain.Entities
{
    public class Category
    {
        public uint Id { get; set; }
        public required string Name { get; set; }
        public ICollection<StoryCategory> StoryCategories { get; set; } = new HashSet<StoryCategory>();
    }
}
