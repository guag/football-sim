namespace FootballSim.Models
{
    public interface IDraftClassFactory
    {
        IDraftClass Create(int year, int numPlayers);
    }

    public class DraftClassFactory : IDraftClassFactory
    {
        private readonly IMultiplePlayerFactory _playerFactory;

        public DraftClassFactory(IMultiplePlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public IDraftClass Create(int year, int numPlayers)
        {
            return new DraftClass
            {
                Players = _playerFactory.Create(numPlayers),
                Year = year
            };
        }
    }
}