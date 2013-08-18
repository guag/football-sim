using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class DefensiveLineman : Defenseman
    {
        public override int MinWeight
        {
            get { return 270; }
        }

        public override int MaxWeight
        {
            get { return 350; }
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
                base.RatingTypes.Add(RatingType.PassRushing);
                return base.RatingTypes;
            }
        }
    }
}