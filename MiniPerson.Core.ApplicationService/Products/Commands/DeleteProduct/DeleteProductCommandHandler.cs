using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;
using WebLog.Core.Contracts.People.Commands;
using WebLog.Core.Domain.People.Entities;
using WebLog.Core.Contracts.Products.Commands;
using WebLog.Core.Contracts.Products.Commands.DeleteProduct;

namespace WebLog.Core.ApplicationService.Products.Commands.DeleteProduct
{
    public class DeleteProductCommandHandler : CommandHandler<DeleteProductCommand, bool>
    {

        private readonly IProductCommandRepository _productCommandRepository;
        private readonly IPersonCommandRepository _personCommandRepository;

        public DeleteProductCommandHandler(ZaminServices zaminServices,
                                        IProductCommandRepository productCommandRepository,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _productCommandRepository = productCommandRepository;
            _personCommandRepository = personCommandRepository;
        }

        public IPersonCommandRepository PersonCommandRepository { get; }

        public override async Task<CommandResult<bool>> Handle(DeleteProductCommand command)
        {
            _productCommandRepository.Delete(command.ProductId);

            List<Person> people = await _personCommandRepository.GetPersonListByProductIdAsync(command.ProductId);
            foreach (var person in people)
            {
                person.DeActivePersonProducts(command.ProductId);
            }

            await _productCommandRepository.CommitAsync();
            var result = true;
            return Ok(result);
        }
    }
}
