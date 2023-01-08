using MiniPerson.Core.Contracts.People.Queries.GetPersonById;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniPerson.Core.Contracts.People.Queries.GetPeople
{
    public class GetPeopleQuery: PageQuery<PagedData<PersonQr>>
    {
    }
}
