using System.ComponentModel.DataAnnotations;
using Actor.Infrastructure.Enum;

namespace Actor.Infrastructure.Entities;

public class Notification : BaseEntity
{
    public DateTime ApplyDate { get; set; }
    // Relation

    public int ReceiverId { get; set; }
    public virtual Actor? Actor { get; set; }

    public int SenderId { get; set; }
    public virtual Director? Director { get; set; }
}