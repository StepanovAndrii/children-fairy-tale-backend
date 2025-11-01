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
                .Where(culture => culture.TwoLetterISOLanguageName != "iv")
                .Select((culture, index) => new Language
                {
                    Id = (uint)index + 1,
                    Code = new LanguageCode(culture.TwoLetterISOLanguageName)
                })
                .GroupBy(language => language.Code.Value)
                .Select(group => group.First())
                .ToList();
        }
    }
}
