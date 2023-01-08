
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.People.Cammands.CreatePersonProduct
{
    public class CreatePersonProductCommand : ICommand<long>
    {
        public long PersonId { get; set; }
        public long ProductId { get; set; }
    }
}
