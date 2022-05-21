using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Serialization;

namespace IO.Swagger.Models
{
    [DataContract]
    public class Obs
    {
        [Required]
        [MaxLength(4)]
        [DataMember(Name = "alive")]
        public IList<Item> Alive { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "board")]
        public IList<IList<Item>> Board { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "bomb_blast_strength")]
        public IList<IList<float>> BombBlastStrength { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "bomb_life")]
        public IList<IList<float>> BombLife { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "bomb_moving_direction")]
        public IList<IList<float>> BombMovingDirection { get; set; }

        [Required]
        [MinLength(11)]
        [MaxLength(11)]
        [DataMember(Name = "flame_life")]
        public IList<IList<float>> FlameLife { get; set; }

        [DataMember(Name = "game_type")]
        public GameType? GameType { get; set; }

        [DataMember(Name = "game_env")]
        public string GameEnv { get; set; }

        [Required]
        [MinLength(2)]
        [MaxLength(2)]
        [DataMember(Name = "position")]
        public IList<int> Position { get; set; }

        [Required]
        [DataMember(Name = "blast_strength")]
        public int BlastStrength { get; set; }

        [Required]
        [DataMember(Name = "can_kick")]
        public bool CanKick { get; set; }

        [DataMember(Name = "teammate")]
        public Item? Teammate { get; set; }

        [Required]
        [DataMember(Name = "ammo")]
        public int Ammo { get; set; }

        [Required]
        [DataMember(Name = "enemies")]
        public IList<Item> Enemies { get; set; }

        [Required]
        [DataMember(Name = "step_count")]
        public int StepCount { get; set; }
    }
}
