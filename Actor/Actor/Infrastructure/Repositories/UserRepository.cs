using Actor.Application.Models.Requests;
using Actor.Infrastructure.DbContext;
using Actor.Infrastructure.Entities;
using Actor.Infrastructure.Interfaces.IRepositories;
using Actor.Infrastructure.Repositories.IRepositories;
using Microsoft.EntityFrameworkCore;

namespace Actor.Infrastructure.Repositories;

public class UserRepository : BaseRepository<User>, IUserRepository
{
    public UserRepository(AppDbContext context) : base(context)
    {
    }

    public User? CheckLogin(LoginDtoRequest dto)
    {
        return DbSet.Include(x => x.Role)
            .FirstOrDefault(x => x.Email == dto.Email && x.Password == dto.Password);
    }
}