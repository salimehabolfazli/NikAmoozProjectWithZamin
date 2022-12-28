
using MiniPerson.Core.Contracts.Products.Queries;
using MiniPerson.Core.Contracts.Products.Queries.GetAllProduct;
using MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Common;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Products.Queries.GetAllProduct
{
    public class GetAllProductHandler : QueryHandler<GetAllProductQuery, PagedData<ProductQr>>
    {
        private readonly IProductQueryRepository productQueryRepository;

        public GetAllProductHandler(ZaminServices zaminervices, IProductQueryRepository productQueryRepository) : base(zaminervices)
        {
            this.productQueryRepository = productQueryRepository;
        }

        public override async Task<QueryResult<PagedData<ProductQr>>> Handle(GetAllProductQuery query)
        {
            var result = productQueryRepository.Execute(query);

            return Result(result);
        }
    }
}
