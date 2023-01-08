
using MiniPerson.Core.Contracts.Products.Queries;
using MiniPerson.Core.Contracts.Products.Queries.GetProducts;
using MiniPerson.Core.Contracts.Products.Queries.GetProductById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Products.Queries.GetAllProduct
{
    public class GetProductsHandler : QueryHandler<GetProductsQuery, PagedData<ProductQr>>
    {
        private readonly IProductQueryRepository productQueryRepository;

        public GetProductsHandler(ZaminServices zaminervices, IProductQueryRepository productQueryRepository) : base(zaminervices)
        {
            this.productQueryRepository = productQueryRepository;
        }

        public override async Task<QueryResult<PagedData<ProductQr>>> Handle(GetProductsQuery query)
        {
            var result = productQueryRepository.Execute(query);

            return Result(result);
        }
    }
}
