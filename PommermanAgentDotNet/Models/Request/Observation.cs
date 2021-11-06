namespace PommermanAgentDotNet.Models
{
    public class Observation
    {
        public int[] Alive { get; set; }

        /// <summary>
        /// The board is a two-dimensional array where the inner
        /// arrays are the rows of the board. So Board[y][x] is
        /// the cell in row y, column x. We start counting from the
        /// top left corner.
        /// </summary>
        public Item[][] Board { get; set; }

        public float[][] Bomb_blast_strength { get; set; }

        public float[][] Bomb_life { get; set; }

        public float[][] Bomb_moving_direction { get; set; }

        public float[][] Flame_life { get; set; }

        public GameType Game_type { get; set; }

        public string Game_env { get; set; }

        /// <summary>
        /// Position has two items, namely an x-coordinate and a
        /// y-coordinate. The first element of Position is the
        /// y-coordinate and the second element is the x-coordinate.
        /// We start counting from the top left corner, so [0,0]
        /// will be the top left corner and [2,3] will be the cell
        /// located in the third row and the fourth column.
        /// Thus, Board[Position[0]][Position[1]] should be you.
        /// </summary>
        public int[] Position { get; set; }

        public int Blast_strength { get; set; }

        public bool Can_kick { get; set; }

        public int Teammate { get; set; }

        public int Ammo { get; set; }

        public int[] Enemies { get; set; }

        public int Step_count { get; set; }
    }
}
