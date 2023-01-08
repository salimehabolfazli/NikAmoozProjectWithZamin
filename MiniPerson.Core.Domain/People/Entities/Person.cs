using GymProducts.Core.Domain;
using MiniPerson.Core.Domain.People.ValueObjects;
using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Exceptions;

namespace MiniPerson.Core.Domain.People.Entities
{
    public class Person : AggregateRoot
    {
        #region Field
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public List<PersonPhoneNumber> PhoneNumbers { get; private set; }
        public List<PersonProduct> Products { get; private set; }
        #endregion

        #region Constructors
        private Person()
        {

        }
        public Person(string firstName, string lastName)
        {
            PhoneNumbers = new List<PersonPhoneNumber>();
            Products = new List<PersonProduct>();
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Events
        public void UpdatePerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
        #endregion

        #region Event PersonPhoneNumber
        public PersonPhoneNumber AddPersonPhoneNumber(PhoneNumber phoneNumber)
        {
            var personPhoneNumber = PhoneNumbers.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
            if (personPhoneNumber == null)
            {
                personPhoneNumber = new PersonPhoneNumber(Id, phoneNumber);
                PhoneNumbers.Add(personPhoneNumber);
            }
            return personPhoneNumber;
        }
        public long RemovePersonPhoneNumber(PhoneNumber phoneNumber)
        {
            var personPhoneNumber = PhoneNumbers.FirstOrDefault(x => x.PhoneNumber == phoneNumber);
            if (personPhoneNumber == null)
                throw new InvalidEntityStateException(PersonResource.PhoneNumberNotExistError);

            PhoneNumbers.Remove(personPhoneNumber);
            return personPhoneNumber.Id;
        }
        public void AddPersonPhoneNumbers(List<PersonPhoneNumber> phoneNumbers)
        {
            PhoneNumbers.AddRange(phoneNumbers);
        }
        #endregion
        #region Event PersonProduct
        public PersonProduct AddPersonProduct(long productId)
        {
            if (Products.Any(x => x.ProductId == productId))
                throw new InvalidEntityStateException(PersonResource.PersonProductExistError);

            PersonProduct personProduct = new PersonProduct(Id, productId);
            Products.Add(personProduct);
            return personProduct;
        }
        public long RemovePersonProduct(long personProductId)
        {
            var personProduct = Products.FirstOrDefault(x => x.Id == personProductId);
            if (personProduct == null)
                throw new InvalidEntityStateException(PersonResource.PersonProductExistError);

            Products.Remove(personProduct);
            return personProduct.Id;
        }
        public void DeActivePersonProducts(long productId)
        {
            Products.Where(x => x.ProductId == productId).FirstOrDefault().DeActive();
        }
        #endregion
    }
}
