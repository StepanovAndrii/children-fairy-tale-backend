using Domain.Entities;
using Domain.ValueObjects;
using System.Globalization;

namespace Persistence.SeedGenerators
{
    public static class LanguageSeed
    {
        public static List<Language> GetAllLanguages()
        {
            return CultureInfo.GetCultures(CultureTypes.NeutralCultures)
                .Where(culture => !string.IsNullOrWhiteSpace(culture.TwoLetterISOLanguageName) &&
                    culture.TwoLetterISOLanguageName.Length == 2)
                .Select((culture, index) => new Language
                {
                    Id = index + 1,
                    Code = new LanguageCode(culture.TwoLetterISOLanguageName),
                    Name = culture.EnglishName
                })
                .GroupBy(language => language.Code.Value)
                .Select(group => group.First())
                .ToList();
        }
    }
}
