using PommermanAgentDotNet.Models;

namespace PommermanAgentDotNet.Services
{
    public interface IAgentService
    {
        public void Init();

        public AgentAction Act(Item[][] board, int[] position);

        public void EpisodeEnd(int reward);

        public void Shutdown();
    }
}
