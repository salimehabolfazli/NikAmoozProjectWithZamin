namespace WebLog.Core.Contracts.People.Queries.GetPersonById
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
    public class PhoneNumberQr
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string Value { get; set; }
    }
    public class PersonProductQr
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PersonProductQr(long id, Guid businessId, string title, string description)
        {
            Id = id;
            BusinessId = businessId;
            Title = title;
            Description = description;
        }
        public PersonProductQr(long id)
        {
            Id = id;
        }
    }
}
