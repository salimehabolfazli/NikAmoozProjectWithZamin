
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.People.Commands.DeletePerson
{
    public class DeletePersonCommand: ICommand<bool>
    {
        public long PersonId { get; set; }
    }
}
