using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Actor.Infrastructure.Enum;

namespace Actor.Infrastructure.Entities;

public class Transaction : BaseEntity
{
    public DateTime TransactionDate { get; set; }
    public TransactionStatus Status { get; set; }
    [Column(TypeName = "decimal(18, 2)")] 
    public decimal Total { get; set; }
    // Relation

    public int ApplicationId { get; set; }
    public virtual Application? Application { get; set; }
}