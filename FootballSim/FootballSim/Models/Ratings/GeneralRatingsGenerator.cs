namespace FootballSim.Models.Ratings
{
    public interface IGeneralRatingsGenerator
    {
        void Generate(Players.Player player);
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

        public void Generate(Players.Player player)
        {
            int r1 = _random.GetRandom(100);
            player.Ratings.Add(
                RatingType.Speed, new Rating {CurrentValue = r1, ProjectedValue = r1});
            int r2 = _random.GetRandom(100);
            player.Ratings.Add(
                RatingType.Strength, new Rating {CurrentValue = r2, ProjectedValue = r2});
        }

        #endregion
    }
}