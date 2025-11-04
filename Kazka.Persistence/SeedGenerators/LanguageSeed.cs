using Domain.Entities;
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
                    Id = index + 1,
                    Code = culture.TwoLetterISOLanguageName
                })
                .GroupBy(language => language.Code)
                .Select(group => group.First())
                .ToList();
        }
    }
}
