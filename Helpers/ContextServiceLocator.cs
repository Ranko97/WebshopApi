namespace Webshop.Helpers;

public class ContextServiceLocator
{
    private readonly IHttpContextAccessor _httpContextAccessor;

    public ContextServiceLocator(IHttpContextAccessor httpContextAccessor)
    {
        _httpContextAccessor = httpContextAccessor;
    }

}