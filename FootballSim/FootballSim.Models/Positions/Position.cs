using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class Position
    {
        // Default rating types that are common to every position.
        private readonly ISet<RatingType> _ratingTypes = new HashSet<RatingType>
                                                             {
                                                                 RatingType.Acceleration,
                                                                 RatingType.Agility,
                                                                 RatingType.Intelligence,
                                                                 RatingType.Speed,
                                                                 RatingType.Strength
                                                             };

        [Key]
        public int Id { get; set; }

        [Required]
        public abstract PositionType Type { get; }

        [Required]
        public abstract Side Side { get; }

        [Required]
        public abstract int MinWeight { get; }

        [Required]
        public abstract int MaxWeight { get; }

        [Required]
        public abstract int MinHeight { get; }

        [Required]
        public abstract int MaxHeight { get; }

        public virtual ISet<RatingType> RatingTypes
        {
            get { return _ratingTypes; }
        }

        public virtual string ShortName
        {
            get { return Name; }
        }

        public virtual string Name
        {
            get { return Type.ToString(); }
        }

        public override string ToString()
        {
            return ShortName;
        }
    }
}