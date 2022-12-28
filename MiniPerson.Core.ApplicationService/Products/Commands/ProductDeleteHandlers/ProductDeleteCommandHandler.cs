using MiniPerson.Core.Contracts.Persons.Commands.EditPerson;
using MiniPerson.Core.Contracts.Persons.Commands;
using MiniPerson.Core.Domain.Persons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;
using MiniPerson.Core.Contracts.Persons.Commands.DeletePerson;
using MiniPerson.Core.Contracts.Products.Commands.ProductDelete;
using MiniPerson.Core.Contracts.Products.Commands;

namespace MiniPerson.Core.ApplicationService.Products.Commands.ProductDeleteHandlers
{
    public class ProductDeleteCommandHandler : CommandHandler<ProductDeleteCommand, bool>
    {

        private readonly IProductCommandRepository _productCommandRepository;

        public ProductDeleteCommandHandler(ZaminServices zaminServices,
                                        IProductCommandRepository productCommandRepository) : base(zaminServices)
        {
            _productCommandRepository = productCommandRepository;
        }

        public override async Task<CommandResult<bool>> Handle(ProductDeleteCommand command)
        {
            _productCommandRepository.Delete(command.ProductId);
            await _productCommandRepository.CommitAsync();
            var result = true;
            return Ok(result);
        }
    }
}
