using FootballSim.Models.Players;
using FootballSim.Models.Positions;

namespace FootballSim.Models.Ratings
{
    public interface IRatingsBuilder : IPlayerBuildingBlock
    {
    }

    public class RatingsBuilder : IRatingsBuilder
    {
        private readonly IRandomService _random;

        public RatingsBuilder(IRandomService random)
        {
            _random = random;
        }

        #region IRatingsBuilder Members

        public void Build(Player player, Position position = null)
        {
            foreach (RatingType type in player.Position.RatingTypes)
            {
                player.Ratings.Add(type, new Rating(_random.GetRandom(50, 100)));
            }
        }

        #endregion
    }
}