using MiniPerson.Core.Contracts.People.Queries;
using MiniPerson.Core.Contracts.People.Queries.GetPersonById;
using MiniPerson.Core.Contracts.Products.Queries;
using MiniPerson.Core.Contracts.Products.Queries.GetProductById;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.People.Queries.GetPersonById;

public class GetPersonByIdHandler : QueryHandler<GetPersonByIdQuery, PersonQr>
{
    private readonly IPersonQueryRepository _personQueryRepository;
    private readonly IProductQueryRepository _productQueryRepository;
    public GetPersonByIdHandler(ZaminServices zaminServices,
                                      IPersonQueryRepository personQueryRepository, IProductQueryRepository productQueryRepository) : base(zaminServices)
    {
        _personQueryRepository = personQueryRepository;
        _productQueryRepository = productQueryRepository;
    }

    public override async Task<QueryResult<PersonQr>> Handle(GetPersonByIdQuery query)
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
