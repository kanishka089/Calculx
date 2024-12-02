using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CalculX.Base.Entities;

public abstract class AuditLogBase
{
    [Column("ID"), Key]
    public Guid Id { get; set; } = Guid.NewGuid();

    [Column("REF_NO"), MaxLength(200)]
    public required Guid RefNo { get; set; }

    [Column("TYPE"), MaxLength(100)]
    public required string Type { get; set; }

    [Column("TABLE"), MaxLength(200)]
    public required string Table { get; set; }

    [Column("DESCRIPTION")]
    [StringLength(65536)]
    public required string? Description { get; set; }

    [Column("CREATED_BY"), MaxLength(20)]
    public required string CreatedBy { get; set; }

    [Column("CREATED")]
    public required DateTime Created { get; set; } = DateTime.Now;
}
