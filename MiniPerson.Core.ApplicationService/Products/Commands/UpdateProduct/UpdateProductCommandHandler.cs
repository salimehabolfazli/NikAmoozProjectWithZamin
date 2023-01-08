

using MiniPerson.Core.Contracts.Products.Commands;
using MiniPerson.Core.Contracts.Products.Commands.UpdateProduct;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Common;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Products.Commands.UpdateProduct
{
    public class UpdateProductHandler : CommandHandler<UpdateProductCommand, long>
    {
        private readonly IProductCommandRepository productCommandRepository;

        public UpdateProductHandler(ZaminServices zaminServices,
                                    IProductCommandRepository productCommandRepository) : base(zaminServices)
        {
            this.productCommandRepository = productCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(UpdateProductCommand command)
        {
            var product = await productCommandRepository.GetGraphAsync(command.ProductId);
            if (product == null)
                return Result(command.ProductId, ApplicationServiceStatus.NotFound);

            product.ProductUpdate(command.Title,command.Description);
            await productCommandRepository.CommitAsync();
            return Ok(product.Id);
        }
    }
}
