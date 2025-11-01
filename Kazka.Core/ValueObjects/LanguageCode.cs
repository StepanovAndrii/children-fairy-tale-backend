using System.Globalization;

namespace Domain.ValueObjects
{
    public record LanguageCode
    {
        private static readonly HashSet<string> _allLanguageCodes =
            new HashSet<string>(
                CultureInfo.GetCultures(CultureTypes.NeutralCultures)
                    .Select(culture => culture.TwoLetterISOLanguageName.ToLowerInvariant()),
                StringComparer.Ordinal
            );
        public string Value { get; }
        public LanguageCode(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
                // TODO: replace with result obj
                throw new ArgumentNullException("Language code can't be empty string", nameof(value));

            value = value.ToLowerInvariant();

            if (!isValidFormat(value))
                // TODO: replace with result obj
                throw new ArgumentException("Language code format is not valid", nameof(value));

            Value = value;
        }
        private bool isValidFormat(string input)
        {
            return _allLanguageCodes.Contains(input);
        }
    }
}
