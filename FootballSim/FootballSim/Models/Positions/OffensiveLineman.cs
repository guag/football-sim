using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class OffensiveLineman : Position
    {
        public override Side Side
        {
            get { return Side.Offense; }
        }

        public override int MinWeight
        {
            get { return 280; }
        }

        public override int MaxWeight
        {
            get { return 380; }
        }

        public override int MinHeight
        {
            get { return 70; }
        }

        public override int MaxHeight
        {
            get { return 84; }
        }

        public override ISet<RatingType> RatingTypes
        {
            get
            {
                base.RatingTypes.Add(RatingType.PassBlocking);
                base.RatingTypes.Add(RatingType.RunBlocking);
                return base.RatingTypes;
            }
        }
    }
}