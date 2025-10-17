using Domain.Entities;
using Domain.ValueObjects;

namespace Domain.Interfaces.Repositories
{
    public interface ILanguageRepository
    {
        Task<Language?> GetLanguageByCodeAsync(LanguageCode languageCode, CancellationToken cancellationToken = default);
    }
}
