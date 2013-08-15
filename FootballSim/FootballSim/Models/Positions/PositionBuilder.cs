using FootballSim.Models.Players;

namespace FootballSim.Models.Positions
{
    public interface IPositionBuilder : IPlayerBuildingBlock
    {
    }

    public class PositionBuilder : IPositionBuilder
    {
        private readonly IMeasurablesBuilder _measurables;
        private readonly IPositionRepository _positions;

        public PositionBuilder(IPositionRepository positions, IMeasurablesBuilder measurables)
        {
            _positions = positions;
            _measurables = measurables;
        }

        #region IPositionBuilder Members

        public void Build(Player player, Position position = null)
        {
            player.Position = position ?? _positions.GetRandomPosition();
            player.Measurables = _measurables.GenerateMeasurables(player.Position);
        }

        #endregion
    }
}