using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Persons.Commands.CreatePerson
{
    public class CreatePersonCommand: ICommand<Guid>
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<string> PhoneNumberList { get; set; }
    }
}
