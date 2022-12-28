using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Persons.PersonProduct.Cammands.CreatePersonProduct
{
    public class CreatePersonProductCommand : ICommand<long>
    {
        public long PersonId { get; set; }
        public long ProductId { get; set; }
    }
}
