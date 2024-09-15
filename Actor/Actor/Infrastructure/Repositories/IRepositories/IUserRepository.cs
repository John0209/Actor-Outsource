using Actor.Application.Models.Requests;
using Actor.Infrastructure.Entities;
using Actor.Infrastructure.Interfaces.IRepositories;

namespace Actor.Infrastructure.Repositories.IRepositories;

public interface IUserRepository : IBaseRepository<User>
{
    public User? CheckLogin(LoginDtoRequest dto);
    public bool CheckEmailExist(string email);
    public User? VerifyCode(string email, int code);
}