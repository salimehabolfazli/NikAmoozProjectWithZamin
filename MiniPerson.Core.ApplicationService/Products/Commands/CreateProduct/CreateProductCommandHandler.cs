﻿using WebLog.Core.Domain.People.Entities;
using WebLog.Core.Contracts.Products.Commands;
using WebLog.Core.Contracts.Products.Commands.CreateProduct;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;
using WebLog.Core.Domain.Products.Entities;

namespace WebLog.Core.ApplicationService.Products.Commands.CreateProduct
{
    public class CreateProductCommandHandler : CommandHandler<CreateProductCommand, long>
    {
        private readonly IProductCommandRepository productCommandRepository;

        public CreateProductCommandHandler(ZaminServices zaminServices,
                                            IProductCommandRepository productCommandRepository) : base(zaminServices)
        {
            this.productCommandRepository = productCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(CreateProductCommand command)
        {
            var product = new Product(command.Title, command.Description);
            await productCommandRepository.InsertAsync(product);
            await productCommandRepository.CommitAsync();
            return Ok(product.Id);
        }
    }
}
