using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.People.CreatePersonPhoneNumber
{
    public class CreatePersonPhoneNumberCommand : ICommand<long>
    {
        public long PersonId { get; set; }
        public string Value { get; set; }
    }
}
