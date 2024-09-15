using Actor.Infrastructure.DbContext;
using Actor.Infrastructure.Repositories.IRepositories;

namespace Actor.Infrastructure.Repositories;

public class ActorRepository : BaseRepository<Entities.Actor>, IActorRepository
{
    public ActorRepository(AppDbContext context) : base(context)
    {
    }
}