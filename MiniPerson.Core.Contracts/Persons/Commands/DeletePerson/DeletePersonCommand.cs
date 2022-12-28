using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Persons.Commands.DeletePerson
{
    public class DeletePersonCommand: ICommand<bool>
    {
        public long PersonId { get; set; }
    }
}
