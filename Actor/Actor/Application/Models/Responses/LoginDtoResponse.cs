namespace Actor.Application.Models.Responses;

public class LoginDtoResponse
{
    public int UserId { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Role { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string PhoneNumber { get; set; } = string.Empty;
    public string? PictureUrl { get; set; } = string.Empty;
    public string CreateDate { get; set; } = string.Empty;
}