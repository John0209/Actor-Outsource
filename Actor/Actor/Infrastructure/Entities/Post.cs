using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Actor.Infrastructure.Enum;

namespace Actor.Infrastructure.Entities;

public class Post : BaseEntity
{
    [MaxLength(100)] public string Title { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    [MaxLength(100)] public string MovieName { get; set; } = string.Empty;
    public string? ImageUrl { get; set; } = string.Empty;
    public DateTime PostDate { get; set; }
    public int QuantityRecruit { get; set; }
    public int HireTime { get; set; }
    [Column(TypeName = "decimal(18, 2)")] public decimal HirePrice { get; set; }
    public PostStatus Status { get; set; }

    // Relation

    public int CategoryId { get; set; }
    public virtual Category? Category { get; set; }


    public int DirectorId { get; set; }
    public virtual Director? Director { get; set; }

    public virtual ICollection<Application>? Applications { get; set; } = new List<Application>();
}