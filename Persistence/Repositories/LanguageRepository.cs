using Domain.Entities;
using Domain.Interfaces.Repositories;
using Domain.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class LanguageRepository : ILanguageRepository
    {
        private readonly KazkaDbContext _context;
        public LanguageRepository(KazkaDbContext context)
        {
            _context = context;
        }
        public async Task<Language?> GetLanguageByCodeAsync(LanguageCode languageCode, CancellationToken cancellationToken = default)
        {
            return await _context
                .Languages
                .AsNoTracking()
                .SingleOrDefaultAsync(
                    language => language.Code == languageCode,
                    cancellationToken
                );
        }
    }
}
