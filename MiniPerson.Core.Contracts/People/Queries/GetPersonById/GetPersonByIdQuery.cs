using Zamin.Core.Contracts.ApplicationServices.Queries;

namespace WebLog.Core.Contracts.People.Queries.GetPersonById
{
    public class GetPersonByIdQuery : IQuery<PersonQr>
    {
        public long PersonId { get; set; }
    }
}
