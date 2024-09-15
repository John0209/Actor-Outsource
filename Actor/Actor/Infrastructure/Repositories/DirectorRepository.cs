using Actor.Infrastructure.DbContext;
using Actor.Infrastructure.Entities;
using Actor.Infrastructure.Repositories.IRepositories;

namespace Actor.Infrastructure.Repositories;

public class DirectorRepository : BaseRepository<Director>, IDirectorRepository
{
    public DirectorRepository(AppDbContext context) : base(context)
    {
    }
}