using MiniPerson.Core.Contracts.People.Commands.CreatePerson;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.People.Commands.EditPerson
{
    public class EditPersonCommand: ICommand<long>
    {
        public long PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<EditPhoneNumberCommand> PhoneNumberList { get; set; }

    }
    public class EditPhoneNumberCommand
    {
        public long Id { get; set; }
        public string Value { get; set; }
        public bool IsDeleted { get; set; }

    }
}
