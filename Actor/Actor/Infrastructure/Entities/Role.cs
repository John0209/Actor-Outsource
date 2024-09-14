using System.ComponentModel.DataAnnotations;

namespace Actor.Infrastructure.Entities;

public class Role : BaseEntity
{
    [MaxLength(20)] public string RoleName { get; set; } = string.Empty;

    //Relation
    public virtual ICollection<User> Users { get; set; } = new List<User>();
}