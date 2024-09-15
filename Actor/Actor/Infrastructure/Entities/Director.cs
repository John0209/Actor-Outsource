using System.ComponentModel.DataAnnotations;
using Actor.Infrastructure.Enum;

namespace Actor.Infrastructure.Entities;

public class Director : BaseEntity
{
    [MaxLength(50)] public string? Company { get; set; }
    [MaxLength(50)] public string? WebsiteUrl { get; set; }
    [MaxLength(100)] public string? ActionArea { get; set; }
    // Relation

    public int UserId { get; set; }
    public virtual User? User { get; set; }

    public virtual ICollection<Post>? Posts { get; set; } = new List<Post>();
    public virtual ICollection<Notification>? Notifications { get; set; } = new List<Notification>();
}