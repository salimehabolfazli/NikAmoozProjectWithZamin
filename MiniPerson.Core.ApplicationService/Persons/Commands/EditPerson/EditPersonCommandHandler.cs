using MiniPerson.Core.Contracts.Persons.Commands;
using MiniPerson.Core.Contracts.Persons.Commands.EditPerson;
using MiniPerson.Core.Domain.Persons.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;

namespace MiniPerson.Core.ApplicationService.Persons.Commands.EditPerson
{
    internal class EditPersonCommandHandler : CommandHandler<EditPersonCommand, bool>
    {

        private readonly IPersonCommandRepository _personCommandRepository;

        public EditPersonCommandHandler(ZaminServices zaminServices,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _personCommandRepository = personCommandRepository;
        }

        public override async Task<CommandResult<bool>> Handle(EditPersonCommand command)
        {
            bool result = await _personCommandRepository.Edit(command);
            await _personCommandRepository.CommitAsync();
            return Ok(result);
        }
    }
}
