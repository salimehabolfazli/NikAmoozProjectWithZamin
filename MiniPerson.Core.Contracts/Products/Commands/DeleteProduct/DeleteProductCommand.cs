using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Products.Commands.DeleteProduct
{
    public class DeleteProductCommand : ICommand<bool>
    {
        public long ProductId { get; set; }
    }
}
