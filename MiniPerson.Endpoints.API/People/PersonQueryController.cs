using Microsoft.AspNetCore.Mvc;
using MiniPerson.Core.Contracts.People.Queries.GetPersonById;
using MiniPerson.Core.Contracts.People.Queries.GetPeople;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;

namespace MiniPerson.Endpoints.API.People
{
    [Route("api/[controller]")]
    public class PersonQueryController : BaseController
    {
        [HttpGet("GetPersonById")]
        public async Task<IActionResult> GetPersonById(GetPersonByIdQuery query)
            => await Query<GetPersonByIdQuery, PersonQr>(query);

        [HttpGet("GetPeople")]
        public async Task<IActionResult> GetPeople(GetPeopleQuery query)
            => await Query<GetPeopleQuery, PagedData<PersonQr>>(query);

    }
}