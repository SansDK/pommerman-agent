using Microsoft.AspNetCore.Mvc;
using PommermanAgentDotNet.Models;
using PommermanAgentDotNet.Services;

namespace PommermanAgentDotNet.Controllers
{
    [ApiController]
    [Route("episode_end")]
    public class EpisodeEndController : ControllerBase
    {
        private readonly IAgentService _agentService;

        public EpisodeEndController(IAgentService agentService)
        {
            _agentService = agentService;
        }

        [HttpPost]
        public void Post(EpisodeEndRequestPayload episodeEndRequestPayload)
        {
            _agentService.EpisodeEnd(episodeEndRequestPayload.Reward);
        }
    }
}
