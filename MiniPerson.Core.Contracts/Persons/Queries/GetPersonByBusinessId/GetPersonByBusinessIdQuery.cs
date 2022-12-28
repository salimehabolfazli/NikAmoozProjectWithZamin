using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId
{
    public class GetPersonByBusinessIdQuery: IQuery<PersonQr>
    {
        public Guid PersonBusinessId { get; set; }
    }
}
