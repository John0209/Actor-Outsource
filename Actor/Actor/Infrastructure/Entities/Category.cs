using System.ComponentModel.DataAnnotations;

namespace Actor.Infrastructure.Entities;

public class Category : BaseEntity
{
    [MaxLength(40)] public string CategoryName { get; set; } = string.Empty;

    // Relation
    public virtual ICollection<Post>? Posts { get; set; } = new List<Post>();
}