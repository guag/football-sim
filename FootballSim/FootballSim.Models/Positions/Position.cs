using System.Collections.Generic;
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

        public abstract PositionType Type { get; }
        public abstract Side Side { get; }
        public abstract int MinWeight { get; }
        public abstract int MaxWeight { get; }
        public abstract int MinHeight { get; }
        public abstract int MaxHeight { get; }

        public virtual string ShortName
        {
            get { return Name; }
        }

        public virtual string Name
        {
            get { return Type.ToString(); }
        }

        // Note: subclasses can override this to add their own position-specific ratings.
        public virtual ISet<RatingType> RatingTypes
        {
            get { return _ratingTypes; }
        }
    }
}