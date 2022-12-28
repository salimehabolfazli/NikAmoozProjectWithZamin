using MiniPerson.Core.Domain.Persons.ValueObjects;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.ValueObjects;

namespace MiniPerson.Core.Domain.Persons.Entities
{
    public class PersonPhoneNumber : Entity
    {
        public long PersonId { get; set; }
        public PhoneNumber PhoneNumber { get; set; }
        public PersonPhoneNumber()
        {

        }
        public PersonPhoneNumber(long personId, PhoneNumber phoneNumber)
        {
            this.PersonId = personId;
            this.PhoneNumber = phoneNumber;
        }
        public PersonPhoneNumber(string phoneNumber)
        {
            this.PhoneNumber = new PhoneNumber(phoneNumber);
            this.PersonId = PersonId;
        }
    }
}
