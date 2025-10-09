namespace ChildrenFairyTaleBackend.Domain.DomainObjects.ValueObjects
{
    public sealed record Rating 
    {
        public int UserId { get; private init; }
        public int Stars { get; private set; }

        public Rating (int userId, int stars)
        {
            if (stars < 1 || stars > 5)
                throw new ArgumentOutOfRangeException(nameof(stars), "Rating must be between 1 and 5 stars.");

            UserId = userId;
            Stars = stars;
        }
    }
}
