using System;
using System.Collections.Generic;

namespace FootballSim.Models.Ratings
{
    public interface IQuarterbackRatingsGenerator : IPositionRatingsGenerator
    {
    }

    public class QuarterbackRatingsGenerator : IQuarterbackRatingsGenerator
    {
        #region IQuarterbackRatingsGenerator Members

        public IDictionary<RatingType, Rating> Generate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}