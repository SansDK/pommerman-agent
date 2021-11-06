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
        public ActionResponsePayload Post(ActionRequestPayload actionRequestPayload)
        {
            var result = _agentService.Action();

            return new ActionResponsePayload
            {
                Action = result
            };
        }
    }
}
