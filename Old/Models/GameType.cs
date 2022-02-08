namespace PommermanAgentDotNet.Models
{
    /// <summary>
    /// The Game Types.
    /// 
    /// FFA: 1v1v1v1. Submit an agent; it competes against other submitted agents.
    /// Team: 2v2. Submit an agent; it is matched up randomly with another agent
    /// and together take on two other similarly matched agents.
    /// TeamRadio: 2v2. Submit two agents; they are matched up against two other
    /// agents. Each team passes discrete communications to each other.
    /// OneVsOne: 1v1. A research environment for dueling between two agents
    /// </summary>
    public enum GameType
    {
        FFA = 1,
        Team = 2,
        TeamRadio = 3,
        OneVsOne = 4
    }
}
