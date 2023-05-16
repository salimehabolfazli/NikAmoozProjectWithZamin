using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace WebLog.Core.Contracts.People.Commands.CreatePersonProduct
{
    public class CreatePersonProductCommand : ICommand<long>
    {
        public long PersonId { get; set; }
        public long ProductId { get; set; }
    }
}
