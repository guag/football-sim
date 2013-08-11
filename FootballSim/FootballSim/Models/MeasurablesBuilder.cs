using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IMeasurablesBuilder
    {
        Measurables GenerateMeasurables(IPosition position);
    }

    public class MeasurablesBuilder : IMeasurablesBuilder
    {
        private readonly IRandomService _random;

        public MeasurablesBuilder(IRandomService random)
        {
            _random = random;
        }

        #region IMeasurablesGenerator Members

        public Measurables GenerateMeasurables(IPosition position)
        {
            return new Measurables
                       {
                           Height = _random.GetRandom(position.MinHeight, position.MaxHeight),
                           Weight = _random.GetRandom(position.MinWeight, position.MaxWeight)
                       };
        }

        #endregion
    }
}