using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace WebLog.Core.Contracts.People.Commands.CreatePersonPhoneNumber
{
    public class CreatePersonPhoneNumberCommand : ICommand<long>
    {
        public long PersonId { get; set; }
        public string Value { get; set; }
    }
}
