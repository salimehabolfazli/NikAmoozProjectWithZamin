using Microsoft.AspNetCore.Mvc;
using MiniPerson.Core.Contracts.Persons.Commands.CreatePerson;
using MiniPerson.Core.Contracts.Persons.Commands.DeletePerson;
using MiniPerson.Core.Contracts.Persons.Commands.EditPerson;
using MiniPerson.Core.Contracts.Persons.PersonPhoneNumber.CreatePersonPhoneNumber;
using MiniPerson.Core.Contracts.Persons.PersonProduct.Cammands.CreatePersonProduct;
using MiniPerson.Core.Contracts.Persons.Queries.GetPersonByBusinessId;
using MiniPerson.Core.Contracts.Persons.Queries.GetPersonList;
using Zamin.Core.Contracts.Data.Queries;
using Zamin.EndPoints.Web.Controllers;

namespace MiniPerson.Endpoints.API.Persons
{
    [Route("api/[controller]")]
    public class PersonController : BaseController
    {
        [HttpPost("CreatePerson")]
        public async Task<IActionResult> CreatePerson(CreatePersonCommand createPerson)
            => await Create<CreatePersonCommand, Guid>(createPerson);

        [HttpGet("GetPersonByBusinessId")]
        public async Task<IActionResult> GetPersonByBusinessId(GetPersonByBusinessIdQuery query)
            => await Query<GetPersonByBusinessIdQuery, PersonQr>(query);

        [HttpGet("GetPersonList")]
        public async Task<IActionResult> GetPersonList(GetPersonListQuery query)
            => await Query<GetPersonListQuery, PagedData<PersonQr>>(query);

        [HttpDelete("DeletePerson")]
        public async Task<IActionResult> DeletePerson(DeletePersonCommand deletePerson)
            => await Delete<DeletePersonCommand, bool>(deletePerson);

        [HttpPut("EditPerson")]
        public async Task<IActionResult> EditPerson(EditPersonCommand editPerson)
            => await Edit<EditPersonCommand,bool>(editPerson);

        [HttpPut("AddPersonProduct")]
        public async Task<IActionResult> CreatePersonProduct(CreatePersonProductCommand createPersonProduct)
            => await Edit<CreatePersonProductCommand, long>(createPersonProduct);

        [HttpPut("AddPersonPhoneNumber")]
        public async Task<IActionResult> AddPersonPhoneNumber(CreatePersonPhoneNumberCommand createPersonPhoneNumber)
            => await Edit<CreatePersonPhoneNumberCommand, long>(createPersonPhoneNumber);
    }
}