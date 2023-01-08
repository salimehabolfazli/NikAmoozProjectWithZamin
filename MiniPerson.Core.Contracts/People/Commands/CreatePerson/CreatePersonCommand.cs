using MiniPerson.Core.Contracts.People.Cammands.CreatePersonProduct;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.People.Commands.CreatePerson
{
    public class CreatePersonCommand: ICommand<long>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PhoneNumberCommand> PhoneNumberList { get; set; }
    }
}
