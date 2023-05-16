using WebLog.Core.Domain.People.ValueObjects;
using WebLog.Core.Contracts.People.Commands;
using WebLog.Core.Contracts.People.Commands.CreatePersonPhoneNumber;
using WebLog.Core.Domain.People.Entities;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace WebLog.Core.ApplicationService.People.Commands.CreatePersonPhoneNumber
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
            PersonPhoneNumber phoneNumber = person.AddPersonPhoneNumber(new PhoneNumber(command.Value));
            await _personCommandRepository.CommitAsync();
            return Ok(phoneNumber.Id);
        }
    }
}
