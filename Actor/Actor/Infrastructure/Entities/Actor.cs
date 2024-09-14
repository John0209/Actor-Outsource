using System.ComponentModel.DataAnnotations;

namespace Actor.Infrastructure.Entities;

public class Actor : BaseEntity
{
    [MaxLength(50)] public string University { get; set; } = string.Empty;
    public int ExperienceYear { get; set; }
    public int EducationLevel { get; set; }

    // Relation
    public int UserId { get; set; }
    public virtual User? User { get; set; }

    public virtual ICollection<Application>? Applications { get; set; } = new List<Application>();
    public virtual ICollection<Notification>? Notifications { get; set; } = new List<Notification>();
}