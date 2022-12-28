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

namespace MiniPerson.Core.ApplicationService.Persons.Commands.DeletePerson
{
    public class DeletePersonCommandHandler : CommandHandler<DeletePersonCommand, bool>
    {

        private readonly IPersonCommandRepository _personCommandRepository;

        public DeletePersonCommandHandler(ZaminServices zaminServices,
                                        IPersonCommandRepository personCommandRepository) : base(zaminServices)
        {
            _personCommandRepository = personCommandRepository;
        }

        public override async Task<CommandResult<bool>> Handle(DeletePersonCommand command)
        {
            _personCommandRepository.Delete(command.PersonId);
            await _personCommandRepository.CommitAsync();
            var result = true;
            return Ok(result);
        }
    }
}
