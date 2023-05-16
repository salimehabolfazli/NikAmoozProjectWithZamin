using WebLog.Core.Domain.Products.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace WebLog.Core.Contracts.Products.Commands
{
    public interface IProductCommandRepository : ICommandRepository<Product>
    {
    }
}
