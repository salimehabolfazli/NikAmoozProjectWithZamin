using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Persons.PersonPhoneNumber.CreatePersonPhoneNumber
{
    public class CreatePersonPhoneNumberCommand : ICommand<long>
    {
        public long PersonId { get; set; }
        public string Value { get; set; }
    }
}
