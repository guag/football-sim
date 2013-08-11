using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IMeasurablesGenerator
    {
        Measurables GetRandomMeasurables(IPosition position);
    }

    public class MeasurablesGenerator : IMeasurablesGenerator
    {
        private readonly IRandomNumberService _random;

        public MeasurablesGenerator(IRandomNumberService random)
        {
            _random = random;
        }

        #region IMeasurablesGenerator Members

        public Measurables GetRandomMeasurables(IPosition position)
        {
            return new Measurables
                       {
                           Height = _random.GetRandomInt(position.MaxHeight),
                           Weight = _random.GetRandomInt(position.MaxWeight)
                       };
        }

        #endregion
    }
}