using Domain.Entities;
using Domain.Interfaces.Repositories;
using Kazka.Persistence.Repositories.Base;
using Persistence.Contexts;

namespace Persistence.Repositories
{
    public class StoryRepository: Repository<Story>, IStoryRepository
    {
        public StoryRepository(KazkaContext context): base(context)
        {
            
        }
    }
}
