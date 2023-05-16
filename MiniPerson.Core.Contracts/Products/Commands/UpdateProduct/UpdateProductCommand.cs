using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace WebLog.Core.Contracts.Products.Commands.UpdateProduct
{
    public class UpdateProductCommand : ICommand<long>
    {
        public long ProductId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
    }
}
