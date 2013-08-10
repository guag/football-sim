using System.Collections.Generic;

namespace FootballSim.Models.Ratings
{
    public interface IPositionRatingsGenerator
    {
        IDictionary<RatingType, Rating> Generate();
    }
}
