using WebLog.Core.Contracts.People.Commands.EditPerson;
using WebLog.Core.Domain.People.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace WebLog.Core.Contracts.People.Commands
{
    public interface IPersonCommandRepository : ICommandRepository<Person>
    {
        Task<List<Person>> GetPersonListByProductIdAsync(long id);
    }
}
