using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace MiniPerson.Core.Domain.Persons.Entities
{
    public class Product : AggregateRoot
    {
        #region Field
        public Title Title { get; private set; }
        public Description Description { get; private set; }
        public bool IsActive { get; private set; }
        #endregion

        #region Constructor
        private Product() { }
        public Product(Title title, Description description, bool isActive)
        {
            Title = title;
            Description = description;
            IsActive = isActive;
        }

        #endregion
        public void ProductUpdate(Title title, Description description)
        {
            Title = title;
            Description = description;
        }
    }


}
