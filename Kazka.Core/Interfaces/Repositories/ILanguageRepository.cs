using Domain.Entities;
using Domain.ValueObjects;
using Kazka.Core.Interfaces.Repositories.Base;

namespace Domain.Interfaces.Repositories
{
    public interface ILanguageRepository: IRepository<Language>
    {
        Task<Language?> GetLanguageByCodeAsync(LanguageCode languageCode, CancellationToken cancellationToken = default);
    }
}
