using System;
using System.Collections.Generic;

namespace FootballSim.Models.Ratings
{
    public class QuarterbackRatingsGenerator : IPositionRatingsGenerator
    {
        #region IPositionRatingsGenerator Members

        public IDictionary<RatingType, Rating> Generate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}