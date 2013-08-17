using FootballSim.Models.Players;

namespace FootballSim.Models.Ratings
{
    public interface IPlayerRatingsBuilder : IPlayerBuildingBlock
    {
    }

    public class PlayerRatingsBuilder : IPlayerRatingsBuilder
    {
        private readonly IRatingGenerator _rating;

        public PlayerRatingsBuilder(IRatingGenerator rating)
        {
            _rating = rating;
        }

        #region IRatingsBuilder Members

        public void Build(Player player)
        {
            foreach (RatingType type in player.Position.RatingTypes)
            {
                player.Ratings.Add(type, _rating.Generate(player.Caliber));
            }
        }

        #endregion
    }
}