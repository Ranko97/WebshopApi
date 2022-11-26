using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Interfaces;

namespace Data.Models;

public class Product : ICMTimestamps, ISoftDelete
{
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    [Key]
    public Guid Id { get; set; }

    public string? Name { get; set; }
    public string? Description { get; set; }

    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime? Deleted { get; set; }

    public virtual Category? Category { get; set; }
}