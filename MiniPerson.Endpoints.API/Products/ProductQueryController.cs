using Microsoft.AspNetCore.Mvc;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;
using WebLog.Core.Contracts.Products.Queries.GetProductById;
using WebLog.Core.Contracts.Products.Queries.GetProducts;

namespace WebLog.Endpoints.API.Products
{
    [Route("api/[controller]")]
    public class ProductQueryController : BaseController
    {
        [HttpGet("GetProductById")]
        public async Task<IActionResult> GetProductById(GetProductByIdQuery query)
            => await Query<GetProductByIdQuery, ProductQr>(query);

        [HttpGet("GetProductList")]
        public async Task<IActionResult> GetProductList(GetProductsQuery query)
            => await Query<GetProductsQuery, PagedData<ProductQr>>(query);
    }
}