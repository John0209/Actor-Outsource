using Actor.Application.Models.Requests;
using Actor.Application.Models.Responses;
using Actor.Infrastructure.Enum;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Actor.Controllers;

[Produces("application/json")]
[ApiController]
[Route("api/v1/authenticate")]
public class AuthenticateController : ControllerBase
{
    private IMediator _mediator;

    public AuthenticateController(IMediator mediator)
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

    /// <summary>
    /// Chọn role muốn đăng ký, Actor or Director
    /// </summary>
    /// <param name="dto"></param>
    /// <param name="role"></param>
    /// <returns></returns>
    [HttpPost("register")]
    public async Task<ActionResult<RegisterDtoResponse>> Register(RegisterDtoRequest dto, RoleEnum role)
    {
        dto.Role = role;
        var result = await _mediator.Send(dto);
        return Ok(result);
    }

    /// <summary>
    /// Nhập code đã được gửi trong email để xác thực tài khoản
    /// </summary>
    /// <param name="dto"></param>
    /// <returns></returns>
    [HttpPost("verify")]
    public async Task<IActionResult> Verify(VerifyDtoRequest dto)
    {
        await _mediator.Send(dto);

        return Ok(new
        {
            Message = "Verification successful"
        });
    }
}