namespace PommermanAgentDotNet.Models
{
    public class Observation
    {
        public int[] Alive { get; set; }

        public Item[][] Board { get; set; }

        public float[][] Bomb_blast_strength { get; set; }

        public float[][] Bomb_life { get; set; }

        public float[][] Bomb_moving_direction { get; set; }

        public float[][] Flame_life { get; set; }

        public GameType Game_type { get; set; }

        public string Game_env { get; set; }

        public int[] Position { get; set; }

        public int Blast_strength { get; set; }

        public bool Can_kick { get; set; }

        public int Teammate { get; set; }

        public int Ammo { get; set; }

        public int[] Enemies { get; set; }

        public int Step_count { get; set; }
    }
}
