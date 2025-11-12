using Domain.Entities;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Persistence.SeedGenerators
{
    public static class LanguageSeed
    {
        public static List<Language> GetAllLanguages() =>  CultureInfo.GetCultures(CultureTypes.NeutralCultures)
                .Where(culture => culture.TwoLetterISOLanguageName != "iv")
                .Select(culture => culture.TwoLetterISOLanguageName)
                .Distinct()
                .Select((code, index) => new Language
                {
                    Id = index + 1,
                    Code = code
                })
                .ToList();
    }
}
