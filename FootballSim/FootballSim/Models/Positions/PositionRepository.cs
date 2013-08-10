using System.Collections.Generic;

namespace FootballSim.Models.Positions
{
    public interface IPositionRepository : IPlayerBuildingBlock
    {
    }

    public class PositionRepository : IPositionRepository
    {
        private readonly IRandomNumberService _randomService;
        private readonly IMeasurablesGenerator _measurablesGenerator;
        private readonly IList<IPosition> _positions = new List<IPosition>();
        private readonly IPosition _emptyPosition = new EmptyPosition();

        public PositionRepository(IRandomNumberService randomService, IMeasurablesGenerator measurablesGenerator)
        {
            _randomService = randomService;
            _measurablesGenerator = measurablesGenerator;
        }

        public void AddPosition(IPosition positionClass)
        {
            _positions.Add(positionClass);
        }

        public void Build(Player player, IPosition position = null)
        {
            player.Position = position ?? (_positions.Count == 0
                                               ? _emptyPosition
                                               : _positions[_randomService.GetRandomInt(0, _positions.Count)]);
            player.Measurables = _measurablesGenerator.GetRandomMeasurables(player.Position);
        }
    }
}