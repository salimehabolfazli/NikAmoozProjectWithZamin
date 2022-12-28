using MiniPerson.Core.Contracts.Persons.Commands;
using MiniPerson.Core.Contracts.Persons.Commands.CreatePerson;
using MiniPerson.Core.Domain.Persons.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Persons.Commands.CreatePerson
{
    public class CreatePersonCommandHandler : CommandHandler<CreatePersonCommand, Guid>
    {

        private readonly IPersonCommandRepository _personCommandRepository;

        public CreatePersonCommandHandler(ZaminServices zaminServices,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _personCommandRepository = personCommandRepository;
        }

        public override async Task<CommandResult<Guid>> Handle(CreatePersonCommand command)
        {
            Person person = new Person(command.FirstName, command.LastName);
            person.AddPersonPhoneNumbers(command.PhoneNumberList.Select(c => new PersonPhoneNumber(c)).ToList());
            await _personCommandRepository.InsertAsync(person);
            await _personCommandRepository.CommitAsync();
            return Ok(person.BusinessId.Value);
        }
    }
}
