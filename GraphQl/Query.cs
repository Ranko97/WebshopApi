using GraphQL.Types;
using Webshop.GraphQl.Types.General;
using Webshop.GraphQL.Models;
using Webshop.Helpers;

namespace Webshop.GraphQl;

public class Query : ObjectGraphType
{
    public Query(ContextServiceLocator contextServiceLocator)
    {
        Name = "Queries";

        Field<NonNullGraphType<StringGraphType>>("Hero").Description("Hero name").Resolve(context => "Darth Vader");

        // TODO: add paging arguments
        Field<PageDataGType<EndUserGType>>("endUsers").Description("Fetch all end users.").Resolve(context => contextServiceLocator.EndUserRepo.GetAllAsync(null).Result);
    }
}