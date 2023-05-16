using Microsoft.EntityFrameworkCore;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.Infra.Data.Sql.Queries;
using WebLog.Core.Contracts.Products.Queries;
using WebLog.Core.Contracts.Products.Queries.GetProductById;
using WebLog.Core.Contracts.Products.Queries.GetProducts;
using WebLog.Infra.Data.Sql.Queries.Common;

namespace WebLog.Infra.Data.Sql.Queries.Products
{
    public class ProductQueryRepository : BaseQueryRepository<WebLogQueryDbContext>, IProductQueryRepository
    {
        public ProductQueryRepository(WebLogQueryDbContext dbContext) : base(dbContext)
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
