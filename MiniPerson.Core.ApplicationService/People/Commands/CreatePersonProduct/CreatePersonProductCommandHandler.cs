using MiniPerson.Core.Contracts.People.Cammands.CreatePersonProduct;
using MiniPerson.Core.Contracts.People.Commands;
using MiniPerson.Core.Domain.People.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.People.Commands.CreatePersonProduct
{
    public class CreatePersonProductCommandHandler : CommandHandler<CreatePersonProductCommand, long>
    {

        private readonly IPersonCommandRepository _personCommandRepository;

        public CreatePersonProductCommandHandler(ZaminServices zaminServices,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _personCommandRepository = personCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(CreatePersonProductCommand command)
        {
            var person = await _personCommandRepository.GetGraphAsync(command.PersonId);

            PersonProduct personProduct = person.AddPersonProduct(command.ProductId);
            await _personCommandRepository.CommitAsync();
            return Ok(personProduct.Id);
        }
    }
}
