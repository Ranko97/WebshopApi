using GraphQL.Types;
using Webshop.GraphQL.Models;
using Webshop.Helpers;

namespace Webshop.GraphQl;

public class Query : ObjectGraphType
{
    // public static string Hero() => "Luke Skywalker";

    public Query(ContextServiceLocator contextServiceLocator)
    {
        Name = "Queries";

        Field<NonNullGraphType<StringGraphType>>("Hero").Description("Hero name").Resolve(context => "Darth Vader");

        Field<ListGraphType<EndUserGType>>("EndUsers").Description("Fetch all end users.").Resolve(context => contextServiceLocator.EndUserRepo.All().Result);
    }
}