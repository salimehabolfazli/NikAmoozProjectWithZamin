using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Products.Commands.ProductCreate
{
    public class ProductCreateCommand : ICommand<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
    }
}