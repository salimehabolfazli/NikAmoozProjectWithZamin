using MiniPerson.Core.Contracts.People.Commands.EditPerson;
using MiniPerson.Core.Domain.People.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace MiniPerson.Core.Contracts.People.Commands
{
    public interface IPersonCommandRepository: ICommandRepository<Person>
    {
        Task<List<Person>> GetPersonListByProductIdAsync(long id);
    }
}
