using GraphQL.Types;

namespace Webshop.GraphQl.Types.General;

public class PageRequestIGType : InputObjectGraphType<PageRequest>
{
    public PageRequestIGType()
    {
        Name = "PageRequestInput";

        Description = "Common object for grouping pagination params";

        Field<StringGraphType>("query").Description("Query string.");
        Field<StringGraphType>("sortBy").Description("Sort strategy.");
        Field<StringGraphType>("sortOrder").Description("asc or desc");
        Field<IntGraphType>("skip").Description("How many elements to skip.");
        Field<IntGraphType>("take").Description("Number of elements in returned result.");
        Field<BooleanGraphType>("showDeleted");
        Field<DateTimeGraphType>("startDate");
        Field<DateTimeGraphType>("endDate");
    }
}