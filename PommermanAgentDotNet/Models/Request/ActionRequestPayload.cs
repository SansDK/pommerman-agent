namespace PommermanAgentDotNet.Models
{
    public class ActionRequestPayload
    {
        public Observation Obs { get; set; }

        public int Action_space { get; set; }
    }
}
