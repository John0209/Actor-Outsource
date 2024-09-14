using Actor.Infrastructure.Interfaces.IRepositories;
using Actor.Infrastructure.Repositories.IRepositories;

namespace Actor.Application.UnitOfWork;

public interface IUnitOfWork : IDisposable
{
    IUserRepository UserRepository { get; }
    public Task<int> SaveChangeAsync();
}