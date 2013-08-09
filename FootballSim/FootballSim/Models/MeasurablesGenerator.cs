using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IMeasurablesGenerator
    {
        Measurables GetRandomMeasurables(IPosition position);
    }

    public class MeasurablesGenerator : IMeasurablesGenerator
    {
        private readonly IRandomNumberService _randomService;

        public MeasurablesGenerator(IRandomNumberService randomService)
        {
            _randomService = randomService;
        }

        public Measurables GetRandomMeasurables(IPosition position)
        {
            return new Measurables
            {
                Height = _randomService.GetRandomInt(position.MinHeight, position.MaxHeight),
                Weight = _randomService.GetRandomInt(position.MinWeight, position.MaxWeight)
            };
        }
    }
}