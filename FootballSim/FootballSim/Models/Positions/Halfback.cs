using System.Collections.Generic;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Positions
{
    public class Halfback : Runningback
    {
        public override PositionType Type
        {
            get { return PositionType.Halfback; }
        }
    }
}