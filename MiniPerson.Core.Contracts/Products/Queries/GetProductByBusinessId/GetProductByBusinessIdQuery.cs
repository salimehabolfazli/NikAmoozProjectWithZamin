using MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId;
using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId
{
    public class GetProductByBusinessIdQuery : IQuery<ProductQr>
    {
        public Guid ProductBusinessId { get; set; }
        public GetProductByBusinessIdQuery(Guid productBusinessId)
        {
            ProductBusinessId = productBusinessId;  
        }
    }
}
