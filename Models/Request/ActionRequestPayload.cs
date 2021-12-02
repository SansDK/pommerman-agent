namespace PommermanAgentDotNet.Models
{
    public class ActionRequestPayload
    {
        public Observation? Obs { get; set; }

        public string? Action_space { get; set; }
    }
}
