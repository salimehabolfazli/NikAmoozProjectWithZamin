
using MiniPerson.Core.Contracts.Products.Queries.GetProducts;
using MiniPerson.Core.Contracts.Products.Queries.GetProductById;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniPerson.Core.Contracts.Products.Queries
{
    public interface IProductQueryRepository
    {
        Task<ProductQr> Execute(GetProductByIdQuery query);
        Task<ProductQr> Execute(long id);
        PagedData<ProductQr> Execute(GetProductsQuery query);
    }
}
