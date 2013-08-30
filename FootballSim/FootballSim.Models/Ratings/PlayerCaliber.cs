using System.ComponentModel.DataAnnotations;

namespace FootballSim.Models.Ratings
{
    public abstract class PlayerCaliber
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public abstract string Name { get; }

        [Required]
        public abstract int MinValue { get; }

        [Required]
        public abstract int MaxValue { get; }

        public override string ToString()
        {
            return Name;
        }
    }
}