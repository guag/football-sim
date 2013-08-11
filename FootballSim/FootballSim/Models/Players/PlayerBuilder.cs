using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models.Players
{
    public interface IPlayerBuilder
    {
        Player Build(IPosition position = null);
    }

    public class PlayerBuilder : IPlayerBuilder
    {
        private readonly IList<IPlayerBuildingBlock> _buildingBlocks = new List<IPlayerBuildingBlock>();
        private readonly IPlayerFactory _playerFactory;

        public PlayerBuilder(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        #region IPlayerBuilder Members

        public Player Build(IPosition position = null)
        {
            Player player = _playerFactory.Create();
            foreach (IPlayerBuildingBlock buildingBlock in _buildingBlocks)
            {
                buildingBlock.Build(player, position);
            }
            return player;
        }

        #endregion

        public void AddBuildingBlock(IPlayerBuildingBlock buildingBlock)
        {
            _buildingBlocks.Add(buildingBlock);
        }
    }
}