

using MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId;
using MiniPerson.Core.Contracts.Persons.Queries.GetPersonList;
using MiniPerson.Core.Contracts.Products.Queries.GetAllProduct;
using MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniPerson.Core.Contracts.Products.Queries
{
    public interface IProductQueryRepository
    {
        Task<ProductQr> Execute(GetProductByBusinessIdQuery query);
        Task<ProductQr> Execute(long id);
        PagedData<ProductQr> Execute(GetAllProductQuery query);
    }
}
