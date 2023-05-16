using Zamin.Core.Domain.Entities;
using Zamin.Core.Domain.Toolkits.ValueObjects;

namespace WebLog.Core.Domain.Products.Entities
{
    public class Product : AggregateRoot
    {
        #region Field
        public Title Title { get; private set; }
        public Description Description { get; private set; }
        #endregion

        #region Constructor
        private Product() { }
        public Product(Title title, Description description)
        {
            Title = title;
            Description = description;
        }

        #endregion

        #region Events
        public void ProductUpdate(Title title, Description description)
        {
            Title = title;
            Description = description;
        }
        #endregion
    }


}
