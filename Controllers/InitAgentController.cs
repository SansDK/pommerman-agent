using Microsoft.AspNetCore.Mvc;
using PommermanAgentDotNet.Models;
using PommermanAgentDotNet.Services;

namespace PommermanAgentDotNet.Controllers
{
    [ApiController]
    [Route("init_agent")]
    public class InitAgentController : ControllerBase
    {
        private readonly IAgentService _agentService;

        public InitAgentController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        [HttpPost]
        public void Post(InitAgentRequestPayload _)
        {
            _agentService.Init();
        }
    }
}
