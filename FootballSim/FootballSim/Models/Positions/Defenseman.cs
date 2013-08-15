using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class Defenseman : Position
    {
        public override ISet<RatingType> RatingTypes
        {
            get
            {
                base.RatingTypes.Add(RatingType.PassCoverage);
                base.RatingTypes.Add(RatingType.RunDefense);
                base.RatingTypes.Add(RatingType.Catching);
                base.RatingTypes.Add(RatingType.Tackling);
                return base.RatingTypes;
            }
        }

        public override Side Side
        {
            get { return Side.Defense; }
        }
    }
}