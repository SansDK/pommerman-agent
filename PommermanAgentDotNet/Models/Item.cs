namespace PommermanAgentDotNet.Models
{
    /// <summary>
    /// The Items in the game.
    /// 
    /// When picked up:
    ///   - ExtraBomb increments the agent's ammo by 1.
    ///   - IncrRange increments the agent's blast strength by 1.
    ///   - Kick grants the agent the ability to kick items.
    /// 
    /// AgentDummy is used by team games to denote the third enemy and by ffa to
    /// denote the teammate.
    /// </summary>
    public enum Item
    {
        Passage = 0,
        Rigid = 1,
        Wood = 2,
        Bomb = 3,
        Flames = 4,
        Fog = 5,
        ExtraBomb = 6,
        IncrRange = 7,
        Kick = 8,
        AgentDummy = 9,
        Agent0 = 10,
        Agent1 = 11,
        Agent2 = 12,
        Agent3 = 13
    }
}
