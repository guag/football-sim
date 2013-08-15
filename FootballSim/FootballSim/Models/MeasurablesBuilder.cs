﻿using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IMeasurablesBuilder
    {
        Measurables GenerateMeasurables(Position position);
    }

    public class MeasurablesBuilder : IMeasurablesBuilder
    {
        private readonly IRandomService _random;

        public MeasurablesBuilder(IRandomService random)
        {
            _random = random;
        }

        #region IMeasurablesBuilder Members

        public Measurables GenerateMeasurables(Position position)
        {
            return new Measurables
                       {
                           Height = _random.GetRandomWeighted(position.MinHeight, position.MaxHeight),
                           Weight = _random.GetRandomWeighted(position.MinWeight, position.MaxWeight)
                       };
        }

        #endregion
    }
}