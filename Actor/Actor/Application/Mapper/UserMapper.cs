using Actor.Application.Models.Responses;
using Actor.Application.Utils;
using Actor.Infrastructure.Entities;

namespace Actor.Application.Mapper;

public static class UserMapper
{
    public static LoginDtoResponse UserToLoginDtoResponse(User dto) => new LoginDtoResponse()
    {
        UserId = dto.Id,
        UserName = dto.UserName,
        PhoneNumber = dto.PhoneNumber,
        Email = dto.Email,
        CreateDate = DateUtils.FormatDateTimeToDatetimeV1(dto.CreateDate),
        PictureUrl = dto.PictureUrl,
        RoleName = dto.Role!.RoleName
    };
}