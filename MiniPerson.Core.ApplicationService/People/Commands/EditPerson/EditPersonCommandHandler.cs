using MiniPerson.Core.Contracts.People.Commands;
using MiniPerson.Core.Contracts.People.Commands.EditPerson;
using MiniPerson.Core.Domain.People.Entities;
using MiniPerson.Core.Domain.People.ValueObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Common;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.People.Commands.EditPerson
{
    internal class EditPersonCommandHandler : CommandHandler<EditPersonCommand, long>
    {

        private readonly IPersonCommandRepository _personCommandRepository;

        public EditPersonCommandHandler(ZaminServices zaminServices,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _personCommandRepository = personCommandRepository;
        }

        public override async Task<CommandResult<long>> Handle(EditPersonCommand command)
        {
            var person = await _personCommandRepository.GetGraphAsync(command.PersonId);
            if (person == null)
                return Result(command.PersonId, ApplicationServiceStatus.NotFound);

            person.UpdatePerson(person.FirstName, person.LastName);
            foreach (var phonenumber in command.PhoneNumberList)
            {
                if(phonenumber.IsDeleted)
                {
                    person.RemovePersonPhoneNumber(new PhoneNumber(phonenumber.Value));
                }
                else
                {
                    person.AddPersonPhoneNumber(new PhoneNumber(phonenumber.Value));
                }
            }
            await _personCommandRepository.CommitAsync();
            return Ok(person.Id);
        }
    }
}
