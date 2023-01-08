using Microsoft.EntityFrameworkCore;
using MiniPerson.Core.Contracts.People.Commands;
using MiniPerson.Core.Domain.People.Entities;
using MiniPerson.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace MiniPerson.Infra.Data.Sql.Commands.People
{
    public class PersonCommandRepository: BaseCommandRepository<Person, MiniPersonCommandDbContext>,
        IPersonCommandRepository
    {
        public PersonCommandRepository(MiniPersonCommandDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Person>> GetPersonListByProductIdAsync(long id)
        {
            return await _dbContext.Persons.Where(x => x.Products.Any(y=>y.ProductId == id)).ToListAsync();
        }

    }
}
