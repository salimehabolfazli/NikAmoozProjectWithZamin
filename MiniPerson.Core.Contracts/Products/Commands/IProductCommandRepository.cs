using MiniPerson.Core.Domain.People.Entities;
using Zamin.Core.Contracts.Data.Commands;

namespace MiniPerson.Core.Contracts.Products.Commands
{
    public interface IProductCommandRepository : ICommandRepository<Product>
    {
    }
}
