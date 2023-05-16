using WebLog.Core.Contracts.Products.Commands;
using WebLog.Core.Contracts.Products.Commands.UpdateProduct;
using WebLog.Core.Domain.Products.Entities;
using WebLog.Infra.Data.Sql.Commands.Common;
using Zamin.Infra.Data.Sql.Commands;

namespace WebLog.Infra.Data.Sql.Commands.Products
{
    public class ProductCommandRepository : BaseCommandRepository<Product, WebLogCommandDbContext>,
        IProductCommandRepository
    {
        public ProductCommandRepository(WebLogCommandDbContext dbContext) : base(dbContext)
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
