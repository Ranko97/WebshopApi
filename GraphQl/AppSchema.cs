using GraphQL.Types;

namespace Webshop.GraphQl;

public class AppSchema : Schema
{
    public AppSchema(IServiceProvider serviceProvider) : base(serviceProvider)
    {
        Query = (Query)serviceProvider.GetService(typeof(Query));
    }
}