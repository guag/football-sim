using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IPlayerFactory
    {
        Player Create(IPosition position = null, ITeam team = null);
    }

    /// <summary>
    /// TODO: Lots of dependencies here, it's starting to smell bad...
    /// </summary>
    public class PlayerFactory : IPlayerFactory
    {
        private readonly INameGeneratorService _nameGenerator;
        private readonly IHometownRepository _hometowns;
        private readonly ICollegeRepository _colleges;
        private readonly IPositionRepository _positionRepository;
        private readonly IMeasurablesGenerator _measurables;

        public PlayerFactory(
            INameGeneratorService nameGenerator,
            IHometownRepository hometowns,
            ICollegeRepository colleges,
            IPositionRepository positionRepository,
            IMeasurablesGenerator measurables)
        {
            _nameGenerator = nameGenerator;
            _hometowns = hometowns;
            _colleges = colleges;
            _positionRepository = positionRepository;
            _measurables = measurables;
        }

        public Player Create(IPosition position = null, ITeam team = null)
        {
            position = position ?? _positionRepository.GetRandomPosition();
            return new Player
            {
                Position = position,
                Measurables = _measurables.GetRandomMeasurables(position),
                Team = team,
                FirstName = _nameGenerator.GetRandomFirstName(),
                LastName = _nameGenerator.GetRandomLastName(),
                Hometown = _hometowns.GetRandomHometown(),
                College = _colleges.GetRandomCollege()
            };
        }
    }
}