

namespace MiniPerson.EndPoints.UI.DTOs.People
{
    public class PersonQr
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<PersonProductQr> Products { get; set; }
        public List<PhoneNumberQr> PhoneNumbers { get; set; }
    }
}
