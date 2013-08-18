using System.Collections.Generic;

namespace FootballSim.Models.Players
{
    public interface IPlayerBuilder
    {
        Player Build();
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

        public Player Build()
        {
            Player player = _playerFactory.Create();
            foreach (IPlayerBuildingBlock buildingBlock in _buildingBlocks)
            {
                buildingBlock.Build(player);
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