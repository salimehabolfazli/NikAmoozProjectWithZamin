using MiniPerson.Core.Contracts.Products.Commands;
using MiniPerson.Core.Contracts.Products.Commands.UpdateProduct;
using MiniPerson.Core.Domain.People.Entities;
using MiniPerson.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace MiniPerson.Infra.Data.Sql.Commands.Products
{
    public class ProductCommandRepository: BaseCommandRepository<Product, MiniPersonCommandDbContext>,
        IProductCommandRepository
    {
        public ProductCommandRepository(MiniPersonCommandDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<bool> Edit(UpdateProductCommand person)
        {
            //Person personDb = await GetAsync(person.PersonBusinessId);
            //personDb.FirstName = person.FirstName;
            //personDb.LastName = person.LastName;

            return true;
        }

    }
}
