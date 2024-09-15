using Actor.Application.Models.Requests;
using Actor.Infrastructure.DbContext;
using Actor.Infrastructure.Entities;
using Actor.Infrastructure.Enum;
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
            .FirstOrDefault(x => x.Email == dto.Email && x.Password == dto.Password && x.Status == UserStatus.Verified);
    }

    public bool CheckEmailExist(string email)
    {
        return DbSet.Any(x => x.Email == email);
    }

    public User? VerifyCode(string email, int code)
    {
        return DbSet.FirstOrDefault(x => x.Email == email && x.VerifyCode == code);
    }
}