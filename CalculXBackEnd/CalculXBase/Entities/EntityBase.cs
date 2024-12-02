using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CalculX.Base.Entities;

public abstract class EntityBase
{
    [Key, Column("ID")]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Column("CREATED")]
    public required DateTime Created { get; set; } = DateTime.Now;

    [Column("CREATED_BY"), MaxLength(20)]
    public required string CreatedBy { get; set; }

    [Column("UPDATED")]
    public DateTime Updated { get; set; }

    [Column("UPDATED_BY"), MaxLength(20)]
    public string? UpdatedBy { get; set; }

    [Column("COMMENTS"), MaxLength(500)]
    public string? Comments { get; set; }
}
