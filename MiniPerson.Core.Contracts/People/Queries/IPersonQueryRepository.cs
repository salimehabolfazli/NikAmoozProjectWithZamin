using Zamin.Core.Contracts.Data.Queries;
using WebLog.Core.Contracts.People.Queries.GetPeople;
using WebLog.Core.Contracts.People.Queries.GetPersonById;

namespace WebLog.Core.Contracts.People.Queries
{
    public interface IPersonQueryRepository
    {
        public Task<PersonQr> Execute(GetPersonByIdQuery query);
        public PagedData<PersonQr> Execute(GetPeopleQuery query);
    }
}
