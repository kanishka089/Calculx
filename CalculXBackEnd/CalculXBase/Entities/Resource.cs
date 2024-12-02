using CalculXBase.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CalculXBase.Entities;

public class Resource
{
    [Key, Column("ID")]
    public Guid Id { get; set; }

    [Column("STATUS"), Required]
    public required ResourceStatus Status { get; set; } = ResourceStatus.Active;

    [Column("CREATED")]
    public required DateTime Created { get; set; } = DateTime.Now;

    [Column("CREATED_BY"), MaxLength(20)]
    public required string CreatedBy { get; set; }

    [Column("PATH"), MaxLength(1000)]
    public required string Path { get; set; }

    [Column("NAME"), MaxLength(200)]
    public required string Name { get; set; }

    [Column("EXTENSION"), MaxLength(20)]
    public required string Extension { get; set; }
}
