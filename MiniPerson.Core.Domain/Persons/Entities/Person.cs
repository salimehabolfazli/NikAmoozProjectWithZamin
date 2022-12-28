using Zamin.Core.Domain.Entities;

namespace MiniPerson.Core.Domain.Persons.Entities
{
    public class Person : AggregateRoot
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private readonly List<PersonPhoneNumber> _phoneNumbers = new List<PersonPhoneNumber>();
        public IReadOnlyList<PersonPhoneNumber> PhoneNumbers => _phoneNumbers;

        private readonly List<PersonProduct> _personProducts = new List<PersonProduct>();
        public IReadOnlyList<PersonProduct> PersonProducts => _personProducts;

        #region Constructors
        private Person()
        {

        }
        public Person(string firstName, string lastName, List<PersonPhoneNumber> phoneNumbers, List<PersonProduct> personProducts)
        {
            FirstName = firstName;
            LastName = lastName;
            _phoneNumbers.AddRange(phoneNumbers);
            _personProducts.AddRange(personProducts);
        }
        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion
        #region Methods
        public void AddPersonPhoneNumbers(List<PersonPhoneNumber> phoneNumbers)
        {
            _phoneNumbers.AddRange(phoneNumbers);
        }
        public PersonPhoneNumber AddPersonPhoneNumber(PersonPhoneNumber phoneNumber)
        {
            _phoneNumbers.Add(phoneNumber);
            return phoneNumber;
        }
        public void AddPersonProduct(PersonProduct personProduct)
        {
            _personProducts.Add(personProduct);
        }
        public PersonProduct AddPersonProduct(long productId)
        {
            PersonProduct personProduct=new PersonProduct(productId);
            _personProducts.Add(personProduct);
            return personProduct;
        }
        #endregion
        #region Commands
        public static Person Create(string firstName, string lastName, List<PersonPhoneNumber> phoneNumbers, List<PersonProduct> personProducts) => new(firstName, lastName, phoneNumbers, personProducts);

        #endregion
    }
}
