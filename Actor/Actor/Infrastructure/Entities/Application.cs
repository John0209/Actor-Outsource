using System.ComponentModel.DataAnnotations;
using Actor.Infrastructure.Enum;

namespace Actor.Infrastructure.Entities;

public class Application : BaseEntity
{
    public DateTime ApplyDate { get; set; }
    public ApplicationStatus Status { get; set; }
    // Relation

    public int PostId { get; set; }
    public virtual Post? Post { get; set; }

    public int ActorId { get; set; }
    public virtual Actor? Actor { get; set; }

    public virtual Transaction? Transaction { get; set; }
}