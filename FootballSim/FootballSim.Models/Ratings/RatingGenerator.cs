namespace FootballSim.Models.Ratings
{
    public interface IRatingGenerator
    {
        Rating Generate(PlayerCaliber caliber, RatingType type);
    }

    public class RatingGenerator : IRatingGenerator
    {
        private readonly IRatingFactory _factory;
        private readonly IRandomService _random;

        public RatingGenerator(IRandomService random, IRatingFactory factory)
        {
            _random = random;
            _factory = factory;
        }

        #region IRatingGenerator Members

        public Rating Generate(PlayerCaliber caliber, RatingType type)
        {
            var value = _random.GetRandom(caliber.MinValue, caliber.MaxValue);
            return _factory.Create(type, value);
        }

        #endregion
    }
}