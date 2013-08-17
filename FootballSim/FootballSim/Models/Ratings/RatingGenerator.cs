using FootballSim.Models.Draft;

namespace FootballSim.Models.Ratings
{
    public interface IRatingGenerator
    {
        Rating Generate(Caliber caliber);
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

        public Rating Generate(Caliber caliber)
        {
            return _factory.Create(GetRandom(caliber));
        }

        #endregion

        private int GetRandom(Caliber caliber)
        {
            switch (caliber)
            {
                case Caliber.BlueChip:
                    return _random.GetRandom(80, 100);
                case Caliber.High:
                    return _random.GetRandom(70, 90);
                case Caliber.Average:
                    return _random.GetRandom(50, 90);
                default:
                    return _random.GetRandom(50, 70);
            }
        }
    }
}