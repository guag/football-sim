using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class Kicker : Position
    {
        public override Side Side
        {
            get { return Side.SpecialTeams; }
        }

        public override int MinWeight
        {
            get { return 160; }
        }

        public override int MaxWeight
        {
            get { return 240; }
        }

        public override int MinHeight
        {
            get { return 68; }
        }

        public override int MaxHeight
        {
            get { return 76; }
        }

        public override ISet<RatingType> RatingTypes
        {
            get
            {
                base.RatingTypes.Add(RatingType.KickingAccuracy);
                base.RatingTypes.Add(RatingType.KickingPower);
                return base.RatingTypes;
            }
        }
    }
}