using FootballSim.Models.Ratings;

namespace FootballSim.Models.Players
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
                Rating rating = _rating.Generate(player.Caliber, type);
                player.Ratings.Add(rating);
            }
        }

        #endregion
    }
}