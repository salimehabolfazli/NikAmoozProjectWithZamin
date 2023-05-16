using WebLog.Core.Domain.People.Entities;
using WebLog.Core.Domain.People.ValueObjects;
using WebLog.Core.Contracts.People.Commands;
using WebLog.Core.Contracts.People.Commands.CreatePerson;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace WebLog.Core.ApplicationService.People.Commands.CreatePerson
{
    public class CreatePersonCommandHandler : CommandHandler<CreatePersonCommand, long>
    {

        private readonly IPersonCommandRepository _personCommandRepository;

        public CreatePersonCommandHandler(ZaminServices zaminServices,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _personCommandRepository = personCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(CreatePersonCommand command)
        {
            Person person = new Person(command.FirstName, command.LastName);
            person.AddPersonPhoneNumbers(command.PhoneNumberList.Select(c => new PersonPhoneNumber(c.Value)).ToList());
            await _personCommandRepository.InsertAsync(person);
            await _personCommandRepository.CommitAsync();
            return Ok(person.Id);
        }
    }
}
