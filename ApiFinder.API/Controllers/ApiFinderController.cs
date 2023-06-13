using ApiFinder.API.Controllers.Base;
using ApiFinder.Application.Features.Commands.UpdateApiInformation;
using ApiFinder.Application.Features.Queries.GetApiInformationList;
using Microsoft.AspNetCore.Mvc;

namespace ApiFinder.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiFinderController : BaseController
    {
        [HttpGet("GetApiInformationList")]
        public async Task<ActionResult> GetApiInformationList()
        {
            var result = await Mediator.Send(new GetApiInformationListQuery());
            return Ok(result);
        }

        [HttpPost("UpdateApiInformation")]
        public async Task<ActionResult> UpdateApiInformation(UpdateApiInformationCommandExternal updateApiInformationCommandExternal)
        {
            var result = await Mediator.Send(new UpdateApiInformationCommand() { ApiInformationId = updateApiInformationCommandExternal.ApiInformationId, Status = updateApiInformationCommandExternal.Status});
            return Ok(result);
        }
    }
}
