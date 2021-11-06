using Microsoft.AspNetCore.Mvc;
using PommermanAgentDotNet.Models;
using PommermanAgentDotNet.Services;
using System.Text.Json;

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
            Observation observation = JsonSerializer.Deserialize<Observation>(
                actionRequestPayload.Obs,
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
            
            var result = _agentService.Act(
                observation.Board,
                observation.Position);

            return new ActionResponsePayload
            {
                Action = result
            };
        }
    }
}
