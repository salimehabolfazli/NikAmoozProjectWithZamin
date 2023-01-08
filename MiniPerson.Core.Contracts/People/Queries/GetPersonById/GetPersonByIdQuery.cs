using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace MiniPerson.Core.Contracts.People.Queries.GetPersonById
{
    public class GetPersonByIdQuery: IQuery<PersonQr>
    {
        public long PersonId { get; set; }
    }
}
