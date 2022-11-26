using Data.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace Models;

public class Enduser : IdentityUser<Guid>, ICMTimestamps, ISoftDelete
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public bool IsActive { get; set; }

    public DateTime Created { get; set; }
    public DateTime Modified { get; set; }
    public DateTime? Deleted { get; set; }
}