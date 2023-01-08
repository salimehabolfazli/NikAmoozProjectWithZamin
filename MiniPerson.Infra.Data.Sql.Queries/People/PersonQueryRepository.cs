using Microsoft.EntityFrameworkCore;
using MiniPerson.Core.Contracts.People.Queries;
using MiniPerson.Core.Contracts.People.Queries.GetPersonById;
using MiniPerson.Core.Contracts.People.Queries.GetPeople;
using MiniPerson.Infra.Data.Sql.Queries.Common;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;

namespace MiniPerson.Infra.Data.Sql.Queries.People
{
    public class PersonQueryRepository : BaseQueryRepository<MiniPersonQueryDbContext>, IPersonQueryRepository
    {
        public PersonQueryRepository(MiniPersonQueryDbContext dbContext) : base(dbContext)
        {
        }

        //public async Task<PersonQr> Execute(GetPersonByBusinessIdQuery query)
        //    => await _dbContext.People.Select(c => new PersonQr()
        //    {
        //        Id = c.Id,
        //        BusinessId = c.BusinessId,
        //        FirstName = c.FirstName,
        //        LastName = c.LastName,
        //        PhoneNumbers = c.PhoneNumbers.Select(c => new PhoneNumberQr
        //        {
        //            Value = c.PhoneNumber,
        //        }).ToList(),
        //    }).FirstOrDefaultAsync(c => c.BusinessId.Equals(query.PersonBusinessId));

        public async Task<PersonQr> Execute(GetPersonByIdQuery query)
            => await _dbContext.Persons.Where(c => c.Id.Equals(query.PersonId)).Select(c => new PersonQr()
            {
                Id = c.Id,
                BusinessId = c.BusinessId,
                FirstName = c.FirstName,
                LastName = c.LastName,
                PhoneNumbers = c.PhoneNumbers.Select(c => new PhoneNumberQr
                {
                    Id=c.Id,
                    BusinessId=c.BusinessId,
                    Value = c.PhoneNumber,
                }).ToList(),
                Products = c.Products.Select(c => new PersonProductQr(c.ProductId)).ToList(),
            }).FirstOrDefaultAsync();

        public PagedData<PersonQr> Execute(GetPeopleQuery personList)
        {
            PagedData<PersonQr> result = new();
            var query = _dbContext.Persons.AsNoTracking();

            result.QueryResult = query.OrderByDescending(c => c.Id).Skip(personList.SkipCount)
                        .Take(personList.PageSize)
                        .Select(c => new PersonQr
                        {
                            BusinessId=c.BusinessId,
                            FirstName = c.FirstName,
                            LastName = c.LastName,
                            Id = c.Id,
                            PhoneNumbers = c.PhoneNumbers.Select(c => new PhoneNumberQr
                            {
                                Id = c.Id,
                                BusinessId = c.BusinessId,
                                Value = c.PhoneNumber,
                            }).ToList(),
                            Products = c.Products.Select(c => new PersonProductQr(c.ProductId)).ToList(),
                        }).ToList();


            if (personList.NeedTotalCount)
            {
                result.TotalCount = query.Count();
            }

            return result;
           
        }
    }
}
