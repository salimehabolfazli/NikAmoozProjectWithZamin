using Microsoft.AspNetCore.Mvc;
using MiniPerson.Core.Contracts.Products.Commands.ProductCreate;
using MiniPerson.Core.Contracts.Products.Commands.ProductDelete;
using MiniPerson.Core.Contracts.Products.Commands.ProductUpdate;
using MiniPerson.Core.Contracts.Products.Queries.GetAllProduct;
using MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;

namespace MiniPerson.Endpoints.API.Products
{
    [Route("api/[controller]")]
    public class ProductController : BaseController
    {
        [HttpPost("CreateProduct")]
        public async Task<IActionResult> CreateProduct(ProductCreateCommand createProduct)
            => await Create<ProductCreateCommand, long>(createProduct);

        [HttpGet("GetProductByBusinessId")]
        public async Task<IActionResult> GetProductByBusinessId(GetProductByBusinessIdQuery query)
            => await Query<GetProductByBusinessIdQuery, ProductQr>(query);

        [HttpGet("GetProductList")]
        public async Task<IActionResult> GetProductList(GetAllProductQuery query)
            => await Query<GetAllProductQuery, PagedData<ProductQr>>(query);

        [HttpDelete("DeleteProduct")]
        public async Task<IActionResult> DeleteProduct(ProductDeleteCommand deleteProduct)
            => await Delete<ProductDeleteCommand, bool>(deleteProduct);

        [HttpPut("EditProduct")]
        public async Task<IActionResult> EditProduct(ProductUpdateCommand editProduct)
            => await Edit<ProductUpdateCommand, long>(editProduct);
    }
}