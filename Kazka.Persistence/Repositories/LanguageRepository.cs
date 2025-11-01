using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.ValueObjects;
using Kazka.Persistence.Repositories.Base;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class LanguageRepository: Repository<Language>, ILanguageRepository
    {
        public LanguageRepository(KazkaContext context): base(context)
        {
            
        }
        
        public async Task<Language?> GetLanguageByCodeAsync(
                LanguageCode languageCode,
                CancellationToken cancellationToken
            )
        {
            return await _context.Languages
                .AsNoTracking()
                .SingleOrDefaultAsync(
                    language => language.Code.Value == languageCode.Value,
                    cancellationToken
                );
        }
    }
}
