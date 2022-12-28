using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Zamin.Core.Contracts.ApplicationServices.Commands;

namespace MiniPerson.Core.Contracts.Persons.Commands.EditPerson
{
    public class EditPersonCommand: ICommand<bool>
    {
        public Guid PersonBusinessId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
