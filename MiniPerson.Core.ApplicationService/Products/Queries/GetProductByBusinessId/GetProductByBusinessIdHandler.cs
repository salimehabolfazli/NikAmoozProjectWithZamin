

using MiniPerson.Core.Contracts.Products.Queries;
using MiniPerson.Core.Contracts.Products.Queries.GetProductById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Products.Queries.GetProductById
{
    class GetProductByIdHandler : QueryHandler<GetProductByIdQuery, ProductQr>
    {
        private readonly IProductQueryRepository productQueryRepository;

        public GetProductByIdHandler(ZaminServices zaminServices, IProductQueryRepository productQueryRepository) : base(zaminServices)
        {
            this.productQueryRepository = productQueryRepository;
        }

        public override async Task<QueryResult<ProductQr>> Handle(GetProductByIdQuery query)
        {
            return Result(await productQueryRepository.Execute(query));
        }
    }
}
