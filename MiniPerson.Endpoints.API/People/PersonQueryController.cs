using Microsoft.AspNetCore.Mvc;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;
using WebLog.Core.Contracts.People.Queries.GetPeople;
using WebLog.Core.Contracts.People.Queries.GetPersonById;

namespace WebLog.Endpoints.API.People
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