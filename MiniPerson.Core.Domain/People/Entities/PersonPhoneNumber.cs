using WebLog.Core.Domain.People.ValueObjects;
using Zamin.Core.Domain.Entities;

namespace WebLog.Core.Domain.People.Entities
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
            PersonId = personId;
            PhoneNumber = phoneNumber;
        }
        public PersonPhoneNumber(string phoneNumber)
        {
            PhoneNumber = new PhoneNumber(phoneNumber);
            PersonId = PersonId;
        }
        #endregion
    }
}
