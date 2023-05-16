using Microsoft.EntityFrameworkCore;
using WebLog.Core.Contracts.People.Commands;
using WebLog.Core.Domain.People.Entities;
using WebLog.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace WebLog.Infra.Data.Sql.Commands.People
{
    public class PersonCommandRepository : BaseCommandRepository<Person, WebLogCommandDbContext>,
        IPersonCommandRepository
    {
        public PersonCommandRepository(WebLogCommandDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<List<Person>> GetPersonListByProductIdAsync(long id)
        {
            return await _dbContext.Persons.Where(x => x.Products.Any(y => y.ProductId == id)).ToListAsync();
        }

    }
}
