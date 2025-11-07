using Domain.Entities;

namespace Kazka.Core.Entities
{
    public class StoryCategory
    {
        public int StoryId { get; set; }
        public required Story Story { get; set; }

        public int CategoryId { get; set; }
        public required Category Category { get; set; }
    }
}
