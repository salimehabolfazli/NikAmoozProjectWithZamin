using Microsoft.AspNetCore.Mvc;
using MiniPerson.Core.Contracts.Products.Commands.CreateProduct;
using MiniPerson.Core.Contracts.Products.Commands.DeleteProduct;
using MiniPerson.Core.Contracts.Products.Commands.UpdateProduct;
using Zamin.EndPoints.Web.Controllers;

namespace MiniPerson.Endpoints.API.Products
{
    [Route("api/[controller]")]
    public class ProductCommandController : BaseController
    {
        [HttpPost("Create")]
        public async Task<IActionResult> CreateProduct([FromBody] CreateProductCommand createProduct)
            => await Create<CreateProductCommand, long>(createProduct);

        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteProduct([FromBody] DeleteProductCommand deleteProduct)
            => await Delete<DeleteProductCommand, bool>(deleteProduct);

        [HttpPut("Edit")]
        public async Task<IActionResult> EditProduct([FromBody] UpdateProductCommand editProduct)
            => await Edit<UpdateProductCommand, long>(editProduct);
    }
}