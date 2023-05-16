using WebLog.Core.Contracts.People.Commands.EditPerson;
using WebLog.Core.Domain.People.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.ApplicationServices.Commands;
using Zamin.Core.Contracts.ApplicationServices.Commands;
using Zamin.Utilities;
using WebLog.Core.Contracts.People.Commands;
using WebLog.Core.Contracts.People.Commands.DeletePerson;

namespace WebLog.Core.ApplicationService.People.Commands.DeletePerson
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
            bool result = true;
            try
            {
                await _personCommandRepository.CommitAsync();
            }
            catch (Exception ex)
            {
                result = false;
            }
            return Ok(result);
        }
    }
}
