using System.ComponentModel.DataAnnotations;
using Actor.Infrastructure.Enum;

namespace Actor.Infrastructure.Entities;

public class User : BaseEntity
{
    [MaxLength(50)] public string UserName { get; set; } = string.Empty;
    [MaxLength(20)] public string PhoneNumber { get; set; } = string.Empty;
    [MaxLength(50)] public string Email { get; set; } = string.Empty;
    [MaxLength(300)] public string? PictureUrl { get; set; } = string.Empty;
    [MaxLength(50)] public string? Address { get; set; } = string.Empty;
    [MaxLength(50)] public string Password { get; set; } = string.Empty;
    public DateTime CreateDate { get; set; }
    public GenderType Gender { get; set; }
    public UserStatus Status { get; set; }

    // Relation
    public int RoleId { get; set; }
    public virtual Role? Role { get; set; }

    public int WalletId { get; set; }
    public virtual Wallet? Wallet { get; set; }

    public virtual Director? Director { get; set; }
    public virtual Actor? Actor { get; set; }
}