using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IPlayerBuilder
    {
        Player Build(IPosition position = null);
    }

    public class PlayerBuilder : IPlayerBuilder
    {
        private readonly IPlayerFactory _playerFactory;
        private readonly IList<IPlayerBuildingBlock> _buildingBlocks = new List<IPlayerBuildingBlock>();

        public PlayerBuilder(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public void AddBuildingBlock(IPlayerBuildingBlock buildingBlock)
        {
            _buildingBlocks.Add(buildingBlock);
        }

        public Player Build(IPosition position = null)
        {
            var player = _playerFactory.Create();
            foreach (var buildingBlock in _buildingBlocks)
            {
                buildingBlock.Build(player, position);
            }
            return player;
        }











        //private readonly INameGeneratorService _nameGenerator;
        //private readonly IHometownRepository _hometowns;
        //private readonly ICollegeRepository _colleges;
        //private readonly IPositionRepository _positionRepository;
        //private readonly IMeasurablesGenerator _measurables;

        //public PlayerBuilder(
        //    INameGeneratorService nameGenerator,
        //    IHometownRepository hometowns,
        //    ICollegeRepository colleges,
        //    IPositionRepository positionRepository,
        //    IMeasurablesGenerator measurables)
        //{
        //    _nameGenerator = nameGenerator;
        //    _hometowns = hometowns;
        //    _colleges = colleges;
        //    _positionRepository = positionRepository;
        //    _measurables = measurables;
        //}

        //public Player Build(IPosition position = null)
        //{
        //    position = position ?? _positionRepository.GetRandomPosition();
        //    return new Player
        //    {
        //        Position = position,
        //        Measurables = _measurables.GetRandomMeasurables(position),
        //        FirstName = _nameGenerator.GetRandomFirstName(),
        //        LastName = _nameGenerator.GetRandomLastName(),
        //        Hometown = _hometowns.GetRandomHometown(),
        //        College = _colleges.GetRandomCollege()
        //    };
        //}
    }
}