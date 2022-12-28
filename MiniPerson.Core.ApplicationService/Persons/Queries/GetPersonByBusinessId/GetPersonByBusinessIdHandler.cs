using MiniPerson.Core.Contracts.Persons.Queries;
using MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId;
using MiniPerson.Core.Contracts.Products.Queries;
using MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Persons.Queries.GetPersonByBusinessId;

public class GetPersonByBusinessIdHandler : QueryHandler<GetPersonByBusinessIdQuery, PersonQr>
{
    private readonly IPersonQueryRepository _personQueryRepository;
    private readonly IProductQueryRepository _productQueryRepository;
    public GetPersonByBusinessIdHandler(ZaminServices zaminServices,
                                      IPersonQueryRepository personQueryRepository, IProductQueryRepository productQueryRepository) : base(zaminServices)
    {
        _personQueryRepository = personQueryRepository;
        _productQueryRepository = productQueryRepository;
    }

    public override async Task<QueryResult<PersonQr>> Handle(GetPersonByBusinessIdQuery query)
    {
        PersonQr result = new();
        result = await _personQueryRepository.Execute(query);
        await GetProductInfo(result);

        return Result(result);
    }

    private async Task GetProductInfo(PersonQr result)
    {
        List<PersonProductQr> productQrList = result.Products;
        result.Products = new List<PersonProductQr>();
        foreach (var personProduct in productQrList)
        {
            ProductQr product = await _productQueryRepository.Execute(personProduct.Id);
            result.Products.Add(new PersonProductQr(product.Id, product.BusinessId, product.Title, product.Description));
        }
    }
}
