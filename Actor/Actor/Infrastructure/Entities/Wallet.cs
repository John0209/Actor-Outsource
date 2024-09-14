using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Actor.Infrastructure.Enum;  

namespace Actor.Infrastructure.Entities;

public class Wallet : BaseEntity
{
    [Column(TypeName = "decimal(18, 2)")] 
    public decimal Money { get; set; }
    // Relation
    public virtual User? User { get; set; }
}