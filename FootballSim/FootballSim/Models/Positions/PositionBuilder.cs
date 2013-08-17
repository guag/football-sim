﻿using FootballSim.Models.Players;

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

        public void Build(Player player)
        {
            player.Position = _positions.GetRandomPosition();
            player.Measurables = _measurables.Build(player.Position);
        }

        #endregion
    }
}