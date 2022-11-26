namespace Data.Interfaces;

public interface ISoftDelete
{
    DateTime? Deleted { get; set; }
}