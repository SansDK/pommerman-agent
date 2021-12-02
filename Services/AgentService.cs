using PommermanAgentDotNet.Models;

namespace PommermanAgentDotNet.Services
{
    public class AgentService : IAgentService
    {
        public void Init()
        {
        }

        public AgentAction Act(Item[][] board, int[] position)
        {
            if (IsPassable(ItemUp(board, position)))
                return AgentAction.Up;
            else if (IsPassable(ItemRight(board, position)))
                return AgentAction.Right;
            else if (IsPassable(ItemDown(board, position)))
                return AgentAction.Down;
            else if (IsPassable(ItemLeft(board, position)))
                return AgentAction.Left;

            // We're locked in!
            return AgentAction.Bomb;
        }

        public void EpisodeEnd(int reward)
        {
        }

        public void Shutdown()
        {
        }

        private static Item? ItemUp(Item[][] board, int[] position)
            => ItemAtOrNull(board, new int[] { position[0] - 1, position[1] });

        private static Item? ItemRight(Item[][] board, int[] position)
            => ItemAtOrNull(board, new int[] { position[0], position[1] + 1 });

        private static Item? ItemDown(Item[][] board, int[] position)
            => ItemAtOrNull(board, new int[] { position[0] + 1, position[1] });

        private static Item? ItemLeft(Item[][] board, int[] position)
            => ItemAtOrNull(board, new int[] { position[0], position[1] - 1 });

        private static Item? ItemAtOrNull(Item[][] board, int[] position)
        {
            if (position[0] < 0 || position[0] >= board.Length)
                return null;
            if (position[1] < 0 || position[1] >= board[0].Length)
                return null;
            return board[position[0]][position[1]];
        }

        private static bool IsPassable(Item? item)
            => item == Item.Passage
            || item == Item.ExtraBomb
            || item == Item.IncrRange
            || item == Item.Kick;
    }
}
