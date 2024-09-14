using Actor.Application.Mapper;
using Actor.Application.Models.Requests;
using Actor.Application.Models.Responses;
using Actor.Application.UnitOfWork;
using Application.ErrorHandlers;
using MediatR;

namespace Actor.Application.Handler;

public class LoginHandler : IRequestHandler<LoginDtoRequest, LoginDtoResponse>
{
    private readonly IUnitOfWork _unit;

    public LoginHandler(IUnitOfWork unit)
    {
        _unit = unit;
    }

    public Task<LoginDtoResponse> Handle(LoginDtoRequest request, CancellationToken cancellationToken)
    {
        var user = _unit.UserRepository.CheckLogin(request) ??
                   throw new UnauthorizedException("Email or password is wrong");

        return Task.FromResult(UserMapper.UserToLoginDtoResponse(user));
    }
}