using PommermanAgentDotNet.Models;

namespace PommermanAgentDotNet.Services
{
    public interface IAgentService
    {
        public void Init();

        public Action Action();

        public void EpisodeEnd(int reward);

        public void Shutdown();
    }
}
