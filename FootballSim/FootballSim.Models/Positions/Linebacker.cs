using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class Linebacker : Defenseman
    {
        public override int MinWeight
        {
            get { return 225; }
        }

        public override int MaxWeight
        {
            get { return 260; }
        }

        public override int MinHeight
        {
            get { return 69; }
        }

        public override int MaxHeight
        {
            get { return 76; }
        }

        public override ISet<RatingType> RatingTypes
        {
            get
            {
                base.RatingTypes.Add(RatingType.PassRushing);
                return base.RatingTypes;
            }
        }
    }
}