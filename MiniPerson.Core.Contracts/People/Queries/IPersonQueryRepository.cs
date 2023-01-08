using MiniPerson.Core.Contracts.People.Queries.GetPersonById;
using MiniPerson.Core.Contracts.People.Queries.GetPeople;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniPerson.Core.Contracts.People.Queries
{
    public interface IPersonQueryRepository
    {
        public Task<PersonQr> Execute(GetPersonByIdQuery query);
        public PagedData<PersonQr> Execute(GetPeopleQuery query);
    }
}
