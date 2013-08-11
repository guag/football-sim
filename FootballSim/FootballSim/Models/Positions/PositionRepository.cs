using System.Collections.Generic;
using FootballSim.Models.Players;

namespace FootballSim.Models.Positions
{
    public interface IPositionRepository : IPlayerBuildingBlock
    {
    }

    public class PositionRepository : IPositionRepository
    {
        private readonly IPosition _emptyPosition = new EmptyPosition();
        private readonly IMeasurablesGenerator _measurablesGenerator;
        private readonly IList<IPosition> _positions = new List<IPosition>();
        private readonly IRandomNumberService _randomService;

        public PositionRepository(IRandomNumberService randomService, IMeasurablesGenerator measurablesGenerator)
        {
            _randomService = randomService;
            _measurablesGenerator = measurablesGenerator;
        }

        #region IPositionRepository Members

        public void Build(Players.Player player, IPosition position = null)
        {
            player.Position = position ?? (_positions.Count == 0
                                               ? _emptyPosition
                                               : _positions[_randomService.GetRandomInt(_positions.Count)]);
            player.Measurables = _measurablesGenerator.GetRandomMeasurables(player.Position);
        }

        #endregion

        public void AddPosition(IPosition positionClass)
        {
            _positions.Add(positionClass);
        }
    }
}