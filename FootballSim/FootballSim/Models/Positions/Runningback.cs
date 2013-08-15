using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public abstract class Runningback : PassCatcher
    {
        public override int MinWeight
        {
            get { return 190; }
        }

        public override int MaxWeight
        {
            get { return 260; }
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
                base.RatingTypes.Add(RatingType.Rushing);
                return base.RatingTypes;
            }
        }
    }
}