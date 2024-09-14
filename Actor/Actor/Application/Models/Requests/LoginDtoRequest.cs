using Actor.Application.Models.Responses;
using MediatR;

namespace Actor.Application.Models.Requests;

public class LoginDtoRequest: IRequest<LoginDtoResponse>
{
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}