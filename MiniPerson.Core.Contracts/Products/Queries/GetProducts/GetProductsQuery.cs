using WebLog.Core.Contracts.Products.Queries.GetProductById;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace WebLog.Core.Contracts.Products.Queries.GetProducts;

public class GetProductsQuery : PageQuery<PagedData<ProductQr>>
{
}
