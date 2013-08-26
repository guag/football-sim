using System.ComponentModel.DataAnnotations;

namespace FootballSim.Models.Ratings
{
    public class Rating
    {
        public Rating(RatingType type, int rating)
        {
            Type = type;
            CurrentValue = rating;
            ProjectedValue = rating;
        }

        public Rating()
        {
        }

        [Key]
        public int Id { get; set; }

        [Required]
        public int CurrentValue { get; set; }

        [Required]
        public int ProjectedValue { get; set; }

        [Required]
        public RatingType Type { get; set; }
    }
}