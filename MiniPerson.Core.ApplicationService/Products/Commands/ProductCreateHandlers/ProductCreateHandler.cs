using MiniPerson.Core.Contracts.Products.Commands;
using MiniPerson.Core.Contracts.Products.Commands.ProductCreate;
using MiniPerson.Core.Domain.Persons.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Products.Commands.ProductCreateHandlers
{
    public class ProductCreateHandler : CommandHandler<ProductCreateCommand, long>
    {
        private readonly IProductCommandRepository productCommandRepository;

        public ProductCreateHandler(ZaminServices zaminServices,
                                            IProductCommandRepository productCommandRepository) : base(zaminServices)
        {
            this.productCommandRepository = productCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(ProductCreateCommand command)
        {
            var product = new Product(command.Title, command.Description,command.IsActive);
            await productCommandRepository.InsertAsync(product);
            await productCommandRepository.CommitAsync();
            return Ok(product.Id);
        }
    }
}
