using MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zamin.Core.Contracts.ApplicationServices.Queries;
using Zamin.Core.Contracts.Data.Queries;

namespace MiniPerson.Core.Contracts.Persons.Queries.GetPersonList
{
    public class GetPersonListQuery: PageQuery<PagedData<PersonQr>>
    {
    }
}
