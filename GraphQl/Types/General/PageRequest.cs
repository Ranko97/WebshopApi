namespace Webshop.GraphQl.Types.General;

public class PageRequest
{
    public string? Query { get; set; }
    public string? SortBy { get; set; }
    public string SortOrder { get; set; } = "desc";
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
    public bool? ShowDeleted { get; set; }
    public int? Skip { get; set; }
    public int? Take { get; set; }

}