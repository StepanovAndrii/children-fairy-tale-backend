using ChildrenFairyTaleBackend.Domain.DomainObjects.ValueObjects;
using ChildrenFairyTaleBackend.Domain.Primitives;

namespace ChildrenFairyTaleBackend.Domain.DomainObjects.Entities
{
    public sealed class Book: Entity
    {
        private readonly HashSet<Rating> _ratings = new();
        public string CoverUrl { get; private set; }
        public string Title { get; private set; }
        public double AverageRating => _ratings.Count == 0 ? 0 : _ratings.Average(raiting => raiting.Starts);
        public Book(string title, string coverUrl)
        {
            Title = title;
            CoverUrl = coverUrl;
        }
        public string Read()
        {
             return Text;
        }
        public void Rate(Rating rating)
        {
            DeleteRate(rating.UserId);

            _ratings.Add(rating);
        }
        public void DeleteRate(int userId)
        {
            var ratingToRemove = _ratings.FirstOrDefault(r => r.UserId == userId);

            if (ratingToRemove != null)
                _ratings.Remove(ratingToRemove);
        }
    }
}
