using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Products.Commands.ProductDelete
{
    public class ProductDeleteCommand : ICommand<bool>
    {
        public long ProductId { get; set; }
    }
}
