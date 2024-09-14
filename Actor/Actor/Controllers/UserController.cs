using Actor.Application.Models.Requests;
using Actor.Application.Models.Responses;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Actor.Controllers;

[Produces("application/json")]
[ApiController]
[Route("api/v1/users")]
public class UserController : ControllerBase
{
    private IMediator _mediator;

    public UserController(IMediator mediator)
    {
        _mediator = mediator;
    }

    /// <summary>
    /// Login by email
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPost("login")]
    public async Task<ActionResult<LoginDtoResponse>> Login(LoginDtoRequest dto)
    {
        var result = await _mediator.Send(dto);
        return Ok(result);
    }
}