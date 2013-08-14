using System.Collections.Generic;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;

namespace FootballSim.Models.Ratings
{
    public interface IRatingsGenerator : IPlayerBuildingBlock
    {
    }

    public class RatingsGenerator : IRatingsGenerator
    {
        private readonly IDictionary<PositionType, IPositionRatingsGenerator> _ratingsGenerators =
            new Dictionary<PositionType, IPositionRatingsGenerator>();

        #region IRatingsGenerator Members

        public void Build(Players.Player player, IPosition position = null)
        {
            if (!_ratingsGenerators.ContainsKey(player.Position.Type))
            {
                return;
            }
            foreach (var rating in _ratingsGenerators[player.Position.Type].Generate())
            {
                player.Ratings.Add(rating);
            }
        }

        #endregion

        public void AddRatingsGenerator(PositionType type, IPositionRatingsGenerator ratingsGenerator)
        {
            _ratingsGenerators.Add(type, ratingsGenerator);
        }
    }
}