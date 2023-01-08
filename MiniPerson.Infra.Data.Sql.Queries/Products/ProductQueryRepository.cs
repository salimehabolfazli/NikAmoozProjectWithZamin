using Microsoft.EntityFrameworkCore;
using MiniPerson.Core.Contracts.Products.Queries;
using MiniPerson.Core.Contracts.Products.Queries.GetProducts;
using MiniPerson.Core.Contracts.Products.Queries.GetProductById;
using MiniPerson.Infra.Data.Sql.Queries.Common;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;

namespace MiniPerson.Infra.Data.Sql.Queries.People
{
    public class ProductQueryRepository : BaseQueryRepository<MiniPersonQueryDbContext>, IProductQueryRepository
    {
        public ProductQueryRepository(MiniPersonQueryDbContext dbContext) : base(dbContext)
        {
        }
        public async Task<ProductQr> Execute(GetProductByIdQuery query)
           => await _dbContext.Products.Where(c => c.Id.Equals(query.ProductId)).Select(c => new ProductQr()
           {
               Id = c.Id,
               BusinessId = c.BusinessId,
               Title = c.Title,
               Description = c.Description,
           }).FirstOrDefaultAsync();
        public async Task<ProductQr> Execute(long id)
            => await _dbContext.Products.Where(c => c.Id.Equals(id)).Select(c => new ProductQr()
            {
                Id = c.Id,
                BusinessId = c.BusinessId,
                Title = c.Title,
                Description = c.Description,
            }).FirstOrDefaultAsync();


        public PagedData<ProductQr> Execute(GetProductsQuery productList)
        {
            PagedData<ProductQr> result = new();
            var query = _dbContext.Products.AsNoTracking();

            result.QueryResult = query.OrderByDescending(c => c.Id).Skip(productList.SkipCount)
                        .Take(productList.PageSize)
                        .Select(c => new ProductQr
                        {
                            Id = c.Id,
                            BusinessId = c.BusinessId,
                            Title = c.Title,
                            Description = c.Description,
                        }).ToList();


            if (productList.NeedTotalCount)
            {
                result.TotalCount = query.Count();
            }

            return result;

        }
    }
}
