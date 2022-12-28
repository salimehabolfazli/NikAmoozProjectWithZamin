using MiniPerson.Core.Contracts.Persons.Commands;
using MiniPerson.Core.Contracts.Persons.Commands.EditPerson;
using MiniPerson.Core.Domain.Persons.Entities;
using MiniPerson.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace MiniPerson.Infra.Data.Sql.Commands.Persons
{
    public class PersonCommandRepository: BaseCommandRepository<Person, MiniPersonCommandDbContext>,
        IPersonCommandRepository
    {
        public PersonCommandRepository(MiniPersonCommandDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> Edit(EditPersonCommand person)
        {
            Person personDb = await GetAsync(person.PersonBusinessId);
            personDb.FirstName = person.FirstName;
            personDb.LastName = person.LastName;

            return true;
        }

    }
}
