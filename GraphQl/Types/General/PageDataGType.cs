using GraphQL.Types;

namespace Webshop.GraphQl.Types.General;

public class PageDataGType<TType> : ObjectGraphType where TType : class, IGraphType
{
    public PageDataGType()
    {
        Name = $"Paginator{typeof(TType).Name}";
        Description = $"Paginator{typeof(TType).Name} description";

        Field<NonNullGraphType<IntGraphType>>(name: "totalCount").Description("Total count description");
        Field<ListGraphType<TType>>(name: "data").Description("Data description");
    }
}