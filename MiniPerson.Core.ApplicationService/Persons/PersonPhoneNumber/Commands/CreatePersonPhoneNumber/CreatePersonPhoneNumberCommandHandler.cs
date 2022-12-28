

using MiniPerson.Core.Contracts.Persons.Commands;
using MiniPerson.Core.Contracts.Persons.PersonPhoneNumber.CreatePersonPhoneNumber;
using MiniPerson.Core.Domain.Persons.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Persons.Commands.CreatePerson
{
    public class CreatePersonPhoneNumberCommandHandler : CommandHandler<CreatePersonPhoneNumberCommand, long>
    {

        private readonly IPersonCommandRepository _personCommandRepository;

        public CreatePersonPhoneNumberCommandHandler(ZaminServices zaminServices,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _personCommandRepository = personCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(CreatePersonPhoneNumberCommand command)
        {
            Person person = await _personCommandRepository.GetAsync(command.PersonId);
            PersonPhoneNumber phoneNumber =person.AddPersonPhoneNumber(new PersonPhoneNumber(command.Value));
            await _personCommandRepository.CommitAsync();
            return Ok(phoneNumber.Id);
        }
    }
}
