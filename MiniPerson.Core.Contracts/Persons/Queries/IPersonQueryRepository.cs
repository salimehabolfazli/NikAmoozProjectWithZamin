using MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId;
using MiniPerson.Core.Contracts.Persons.Queries.GetPersonList;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniPerson.Core.Contracts.Persons.Queries
{
    public interface IPersonQueryRepository
    {
        public Task<PersonQr> Execute(GetPersonByBusinessIdQuery query);
        public PagedData<PersonQr> Execute(GetPersonListQuery query);
    }
}
