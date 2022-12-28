using Zamin.Core.Domain.Entities;

namespace MiniPerson.Core.Domain.Persons.Entities
{
    public class PersonProduct : Entity
    {
        public long PersonId { get; set; }
        public long ProductId { get; set; }
        public PersonProduct(long productId)
        {
            this.ProductId = productId;
        }
        public PersonProduct(long personId, long productId)
        {
            PersonId = personId;
            ProductId = productId;  
        }
    }
}
