using Zamin.Core.Contracts.Data.Queries;
using WebLog.Core.Contracts.Products.Queries.GetProductById;
using WebLog.Core.Contracts.Products.Queries.GetProducts;

namespace WebLog.Core.Contracts.Products.Queries
{
    public interface IProductQueryRepository
    {
        Task<ProductQr> Execute(GetProductByIdQuery query);
        Task<ProductQr> Execute(long id);
        PagedData<ProductQr> Execute(GetProductsQuery query);
    }
}
