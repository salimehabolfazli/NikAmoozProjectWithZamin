using WebLog.Core.Contracts.People.Commands.CreatePersonProduct;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace WebLog.Core.Contracts.People.Commands.CreatePerson
{
    public class CreatePersonCommand : ICommand<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PhoneNumberCommand> PhoneNumberList { get; set; }
    }
}
