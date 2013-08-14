using System.Collections.Generic;

namespace FootballSim.Models.Ratings
{
    public interface IGeneralRatingsGenerator : IPositionRatingsGenerator
    {
    }

    /// <summary>
    /// TODO: properly implement and test this class!
    /// </summary>
    public class GeneralRatingsGenerator : IGeneralRatingsGenerator
    {
        private readonly IRandomService _random;

        public GeneralRatingsGenerator(IRandomService random)
        {
            _random = random;
        }

        #region IGeneralRatingsGenerator Members

        public IDictionary<RatingType, Rating> Generate()
        {
            var result = new Dictionary<RatingType, Rating>();
            int r1 = _random.GetRandom(40, 100);
            result.Add(
                RatingType.Speed, new Rating {CurrentValue = r1, ProjectedValue = r1});
            int r2 = _random.GetRandom(40, 100);
            result.Add(
                RatingType.Strength, new Rating {CurrentValue = r2, ProjectedValue = r2});
            return result;
        }

        #endregion
    }
}