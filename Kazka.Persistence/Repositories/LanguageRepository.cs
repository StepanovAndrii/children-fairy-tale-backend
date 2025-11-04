using Domain.Entities;
using Domain.Interfaces.Repositories;
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
    }
}
