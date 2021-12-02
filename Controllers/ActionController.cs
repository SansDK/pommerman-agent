using Microsoft.AspNetCore.Mvc;
using PommermanAgentDotNet.Models;
using PommermanAgentDotNet.Services;

namespace PommermanAgentDotNet.Controllers
{
    [ApiController]
    [Route("action")]
    public class ActionController : ControllerBase
    {
        private readonly IAgentService _agentService;

        public ActionController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        [HttpPost]
        public IActionResult Post(ActionRequestPayload actionRequestPayload)
        {
            if (actionRequestPayload?.Obs == null)
            {
                return BadRequest("Observation is null!");
            }
            
            var result = _agentService.Act(
                actionRequestPayload.Obs.Board,
                actionRequestPayload.Obs.Position);

            return Ok(new ActionResponsePayload
            {
                Action = result
            });
        }
    }
}
