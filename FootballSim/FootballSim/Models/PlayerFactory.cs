using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IPlayerFactory
    {
        Player Create(IPosition position = null, ITeam team = null);
    }

    public class PlayerFactory : IPlayerFactory
    {
        private readonly INameGeneratorService _nameGenerator;
        private readonly IHometownRepository _hometowns;
        private readonly ICollegeRepository _colleges;
        private readonly IPositionRepository _positionRepository;

        public PlayerFactory(
            INameGeneratorService nameGenerator,
            IHometownRepository hometowns,
            ICollegeRepository colleges,
            IPositionRepository positionRepository)
        {
            _nameGenerator = nameGenerator;
            _hometowns = hometowns;
            _colleges = colleges;
            _positionRepository = positionRepository;
        }

        public Player Create(IPosition position = null, ITeam team = null)
        {
            return new Player
            {
                Position = position ?? _positionRepository.GetRandomPosition(),
                Team = team,
                FirstName = _nameGenerator.GetRandomFirstName(),
                LastName = _nameGenerator.GetRandomLastName(),
                Hometown = _hometowns.GetRandomHometown(),
                College = _colleges.GetRandomCollege()
            };
        }
    }
}