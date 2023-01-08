using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Products.Commands.CreateProduct
{
    public class CreateProductCommand : ICommand<long>
    {
        public string Title { get; set; }
        public string Description { get; set; }
    }
}