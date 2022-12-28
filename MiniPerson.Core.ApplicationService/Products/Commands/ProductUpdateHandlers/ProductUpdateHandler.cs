

using MiniPerson.Core.Contracts.Products.Commands;
using MiniPerson.Core.Contracts.Products.Commands.ProductUpdate;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Common;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Products.Commands.ProductUpdateHandlers
{
    public class ProductUpdateHandler : CommandHandler<ProductUpdateCommand, long>
    {
        private readonly IProductCommandRepository productCommandRepository;

        public ProductUpdateHandler(ZaminServices zaminServices,
                                    IProductCommandRepository productCommandRepository) : base(zaminServices)
        {
            this.productCommandRepository = productCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(ProductUpdateCommand command)
        {
            var product = await productCommandRepository.GetGraphAsync(command.Id);
            if (product == null)
                return Result(command.Id, ApplicationServiceStatus.NotFound);

            product.ProductUpdate(command.Title,command.Description);
            await productCommandRepository.CommitAsync();
            return Ok(product.Id);
        }
    }
}
