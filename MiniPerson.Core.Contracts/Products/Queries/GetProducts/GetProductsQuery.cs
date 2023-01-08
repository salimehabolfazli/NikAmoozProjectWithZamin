using MiniPerson.Core.Contracts.Products.Queries.GetProductById;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniPerson.Core.Contracts.Products.Queries.GetProducts;

public class GetProductsQuery : PageQuery<PagedData<ProductQr>>
{
}
