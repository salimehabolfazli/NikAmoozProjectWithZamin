using Microsoft.AspNetCore.Mvc;
using WebLog.Core.Contracts.People.Commands.CreatePerson;
using WebLog.Core.Contracts.People.Commands.CreatePersonPhoneNumber;
using WebLog.Core.Contracts.People.Commands.CreatePersonProduct;
using WebLog.Core.Contracts.People.Commands.DeletePerson;
using WebLog.Core.Contracts.People.Commands.EditPerson;
using Zamin.EndPoints.Web.Controllers;

namespace WebLog.Endpoints.API.People
{
    [Route("api/[controller]")]
    public class PersonCommandController : BaseController
    {
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreatePersonCommand createPerson)
            => await Create<CreatePersonCommand, long>(createPerson);

        [HttpDelete("Delete")]
        public async Task<IActionResult> Delete(DeletePersonCommand deletePerson)
        {

            IActionResult response = await Delete<DeletePersonCommand, bool>(deletePerson);
            ((ObjectResult)response).StatusCode = 200;
            return response;
        }

        [HttpPut("Edit")]
        public async Task<IActionResult> Edit([FromBody] EditPersonCommand editPerson)
            => await Edit<EditPersonCommand, long>(editPerson);

        [HttpPut("AddPersonProduct")]
        public async Task<IActionResult> CreatePersonProduct([FromBody] CreatePersonProductCommand createPersonProduct)
            => await Edit<CreatePersonProductCommand, long>(createPersonProduct);

        [HttpPut("AddPersonPhoneNumber")]
        public async Task<IActionResult> AddPersonPhoneNumber([FromBody] CreatePersonPhoneNumberCommand createPersonPhoneNumber)
            => await Edit<CreatePersonPhoneNumberCommand, long>(createPersonPhoneNumber);
    }
}