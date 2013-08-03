namespace FootballSim.Models
{
    public interface IPlayerFactory
    {
        Player Create(IPosition position, ITeam team = null);
    }

    public class PlayerFactory : IPlayerFactory
    {
        private readonly INameGeneratorService _nameGenerator;
        private readonly IHometownGeneratorService _hometownGenerator;

        public PlayerFactory(INameGeneratorService nameGenerator, IHometownGeneratorService hometownGenerator)
        {
            _nameGenerator = nameGenerator;
            _hometownGenerator = hometownGenerator;
        }

        public Player Create(IPosition position, ITeam team = null)
        {
            return new Player
            {
                Position = position,
                Team = team,
                FirstName = _nameGenerator.GetRandomFirstName(),
                LastName = _nameGenerator.GetRandomLastName(),
                Hometown = _hometownGenerator.GetRandomHometown()
            };
        }
    }
}