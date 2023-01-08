using Zamin.Core.Domain.Entities;

namespace MiniPerson.Core.Domain.People.Entities
{
    public class PersonProduct : Entity
    {
        #region Fields
        public long PersonId { get; private set; }
        public long ProductId { get; private set; }
        public bool IsActive { get; private set; }
        #endregion

        #region Constructor
        private PersonProduct()
        {

        }
        public PersonProduct(long personId, long productId, bool isActive=true)
        {
            PersonId = personId;
            ProductId = productId;
            IsActive = isActive;
        }

        public void DeActive()
        {
            IsActive= false;
        }
        #endregion
    }
}
