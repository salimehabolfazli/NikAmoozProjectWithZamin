using MiniPerson.Core.Contracts.Persons.Queries;
using MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId;
using MiniPerson.Core.Contracts.Persons.Queries.GetPersonList;
using MiniPerson.Core.Contracts.Products.Queries;
using MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId;
using Zamin.Core.ApplicationServices.Queries;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Core.Domain.Exceptions;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Persons.Queries.GetPersonList;

public class GetPersonListHandler : QueryHandler<GetPersonListQuery, PagedData<PersonQr>>
{
    private readonly IPersonQueryRepository _personQueryRepository;
    private readonly IProductQueryRepository _productQueryRepository;
    public GetPersonListHandler(ZaminServices zaminServices,
                                      IPersonQueryRepository personQueryRepository, IProductQueryRepository productQueryRepository) : base(zaminServices)
    {
        _personQueryRepository = personQueryRepository;
        _productQueryRepository = productQueryRepository;
    }

    public override Task<QueryResult<PagedData<PersonQr>>> Handle(GetPersonListQuery query)
    {
        var personList = _personQueryRepository.Execute(query);
        foreach (var person in personList.QueryResult)
        {
            if (person.Products != null && person.Products.Count > 0)
                GetProductInfo(person);
        }

        return ResultAsync(personList);
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
