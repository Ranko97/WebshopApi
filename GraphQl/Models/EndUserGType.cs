using GraphQL.Types;
using Models;
using Webshop.Helpers;

namespace Webshop.GraphQL.Models;

public class EndUserGType : ObjectGraphType<Enduser>
{

    private readonly ContextServiceLocator serviceLocator;

    public EndUserGType(ContextServiceLocator contextServiceLocator)
    {
        this.serviceLocator = contextServiceLocator;

        Field(x => x.Id, nullable: false, type: typeof(NonNullGraphType<IdGraphType>));
        Field(x => x.UserName, nullable: false, type: typeof(NonNullGraphType<StringGraphType>));
        Field(x => x.FirstName, nullable: false, type: typeof(NonNullGraphType<StringGraphType>));
        Field(x => x.LastName, nullable: false, type: typeof(NonNullGraphType<StringGraphType>));
        Field(x => x.Email, nullable: false, type: typeof(NonNullGraphType<StringGraphType>));
    }
}