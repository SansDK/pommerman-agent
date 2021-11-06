using Microsoft.AspNetCore.Mvc;
using PommermanAgentDotNet.Services;

namespace PommermanAgentDotNet.Controllers
{
    [ApiController]
    [Route("shutdown")]
    public class ShutdownController
    {
        private readonly IAgentService _agentService;

        public ShutdownController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        [HttpPost]
        public void Post()
        {
            _agentService.Shutdown();
        }
    }
}
