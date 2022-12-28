using MiniPerson.Core.Contracts.Products.Queries.GetProductByBusinessId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId
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
        public string Value { get; set; }
        //public int Type { get; set; }
    }
    public class PersonProductQr
    {
        public long Id { get; set; }
        public Guid BusinessId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public PersonProductQr(long id,Guid businessId,string title,string description)
        {
            Id= id;
            BusinessId= businessId; 
            Title= title;
            Description= description;
        }
        public PersonProductQr(long id)
        {
            Id = id;
        }
    }
}
