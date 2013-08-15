using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public class Quarterback : Position
    {
        public override PositionType Type
        {
            get { return PositionType.Quarterback; }
        }

        public override string Name
        {
            get { return "Quarterback"; }
        }

        public override Side Side
        {
            get { return Side.Offense; }
        }

        public override int MinWeight
        {
            get { return 175; }
        }

        public override int MaxWeight
        {
            get { return 265; }
        }

        public override int MinHeight
        {
            get { return 70; }
        }

        public override int MaxHeight
        {
            get { return 78; }
        }

        public override ISet<RatingType> RatingTypes
        {
            get
            {
                base.RatingTypes.Add(RatingType.ThrowingAccuracy);
                base.RatingTypes.Add(RatingType.ThrowingPower);
                base.RatingTypes.Add(RatingType.Rushing);
                return base.RatingTypes;
            }
        }
    }
}