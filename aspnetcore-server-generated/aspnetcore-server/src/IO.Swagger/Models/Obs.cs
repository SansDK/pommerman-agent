using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace IO.Swagger.Models
{
    /// <summary>
    /// The state of the game.
    /// </summary>
    [DataContract]
    public class Obs
    {
        /// <summary>
        /// This array contains the ids of all alive players.
        /// </summary>
        [Required]
        [MaxLength(4)]
        [DataMember(Name = "alive")]
        public IList<Item> Alive { get; set; }

        /// <summary>
        /// The playing board. The first row in this list is the top of the board, and so on.
        /// </summary>
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "board")]
        public IList<IList<Item>> Board { get; set; }

        /// <summary>
        /// The blast strength of each bomb on the playing board. The first row in this list is the top of the board, and so on. If a tile does not contain a bomb, its value will be 0.
        /// </summary>
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "bomb_blast_strength")]
        public IList<IList<float>> BombBlastStrength { get; set; }

        /// <summary>
        /// The remaining time of each bomb on the playing board before it explodes. The first row in this list is the top of the board, and so on. If a tile does not contain a bomb, its value will be 0.
        /// </summary>
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "bomb_life")]
        public IList<IList<float>> BombLife { get; set; }

        /// <summary>
        /// The movement direction of each bomb on the playing board. The first row in this list is the top of the board, and so on. If a tile does not contain a bomb, its value will be 0.
        /// </summary>
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "bomb_moving_direction")]
        public IList<IList<float>> BombMovingDirection { get; set; }

        /// <summary>
        /// The remaining time of each flame on the playing board before it disappears. The first row in this list is the top of the board, and so on. If a tile does not contain a flame, its value will be 0.
        /// </summary>
        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "flame_life")]
        public IList<IList<float>> FlameLife { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "game_type")]
        public GameType? GameType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "game_env")]
        public string GameEnv { get; set; }

        /// <summary>
        /// The `[x, y]` position of your agent on the board. The bottom left cell has `x = 0` and `y = 0`.
        /// </summary>
        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        [DataMember(Name = "position")]
        public IList<int> Position { get; set; }

        /// <summary>
        /// The blast strength of your agent's bombs.
        /// </summary>
        [Required]
        [DataMember(Name = "blast_strength")]
        public int BlastStrength { get; set; }

        /// <summary>
        /// Whether your agent can kick bombs. You can gain this ability by collecting the Kick powerup.
        /// </summary>
        [Required]
        [DataMember(Name = "can_kick")]
        public bool CanKick { get; set; }

        /// <summary>
        ///
        /// </summary>
        [DataMember(Name = "teammate")]
        public Item? Teammate { get; set; }

        /// <summary>
        /// The number of bombs your agent can place.
        /// </summary>
        [Required]
        [DataMember(Name = "ammo")]
        public int Ammo { get; set; }

        /// <summary>
        /// The ids of your enemies.
        /// </summary>
        [Required]
        [DataMember(Name = "enemies")]
        public IList<Item> Enemies { get; set; }

        /// <summary>
        ///
        /// </summary>
        [Required]
        [DataMember(Name = "step_count")]
        public int StepCount { get; set; }
    }
}