using System;

namespace FootballSim.Models
{
    public interface IDraftClassFactory
    {
        IDraftClass Create(DateTime year);
    }

    public class DraftClassFactory : IDraftClassFactory
    {
        private readonly IMultiplePlayerFactory _playerFactory;

        public DraftClassFactory(IMultiplePlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public IDraftClass Create(DateTime year)
        {
            return new DraftClass(_playerFactory.Create(500), year);
        }
    }
}