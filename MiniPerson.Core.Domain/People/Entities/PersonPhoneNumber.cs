using MiniPerson.Core.Domain.People.ValueObjects;
using Zamin.Core.Domain.Entities;

namespace MiniPerson.Core.Domain.People.Entities
{
    public class PersonPhoneNumber : Entity
    {
        #region Fields
        public long PersonId { get; private set; }
        public PhoneNumber PhoneNumber { get; private set; }
        #endregion

        #region Constructor
        private PersonPhoneNumber() { }
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
        #endregion
    }
}
