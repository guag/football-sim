using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class PassCatcher : Position
    {
        public override Side Side
        {
            get { return Side.Offense; }
        }

        public override ISet<RatingType> RatingTypes
        {
            get
            {
                base.RatingTypes.Add(RatingType.Catching);
                base.RatingTypes.Add(RatingType.RunBlocking);
                base.RatingTypes.Add(RatingType.PassBlocking);
                base.RatingTypes.Add(RatingType.RouteRunning);
                return base.RatingTypes;
            }
        }
    }
}