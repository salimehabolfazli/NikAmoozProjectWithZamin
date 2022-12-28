using MiniPerson.Core.Contracts.Persons.Commands.EditPerson;
using MiniPerson.Core.Domain.Persons.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace MiniPerson.Core.Contracts.Persons.Commands
{
    public interface IPersonCommandRepository: ICommandRepository<Person>
    {
        public Task<bool> Edit(EditPersonCommand person);
    }
}
