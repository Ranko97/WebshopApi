namespace Webshop.GraphQl.Types.General;

public class PageData<T>
{
    public int TotalCount { get; set; }
    public List<T>? Data { get; set; }

}