using PommermanAgentDotNet.Models;

namespace PommermanAgentDotNet.Services
{
    public interface IAgentService
    {
        public void Init();

        public Action Act(Item[][] board, int[] position);

        public void EpisodeEnd(int reward);

        public void Shutdown();
    }
}
