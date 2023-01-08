using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace MiniPerson.Core.Contracts.Products.Queries.GetProductById
{
    public class GetProductByIdQuery : IQuery<ProductQr>
    {
        public long ProductId { get; set; }
        public GetProductByIdQuery(long productId)
        {
            ProductId = productId;  
        }
    }
}
