using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace WebLog.Core.Contracts.People.Commands.DeletePerson
{
    public class DeletePersonCommand : ICommand<bool>
    {
        public long PersonId { get; set; }
    }
}
