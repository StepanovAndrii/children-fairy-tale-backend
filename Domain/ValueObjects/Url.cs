namespace Domain.ValueObjects
{
    public record Url
    {
        public string Value { get; }
        public Url(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("URL can't be empty string", nameof(value));
            if (!Uri.IsWellFormedUriString(value, UriKind.RelativeOrAbsolute))
                throw new ArgumentException("URL format is not valid", nameof(value));

            Value = value;
        }
    }
}
