using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IMultiplePlayerFactory
    {
        IEnumerable<Player> Create(int numPlayers, IPosition position = null, ITeam team = null);
    }

    public class MultiplePlayerFactory : IMultiplePlayerFactory
    {
        private readonly IPlayerFactory _playerFactory;

        public MultiplePlayerFactory(IPlayerFactory playerFactory)
        {
            _playerFactory = playerFactory;
        }

        public IEnumerable<Player> Create(int numPlayers, IPosition position = null, ITeam team = null)
        {
            IList<Player> result = new List<Player>();
            for (var i = 0; i < numPlayers; i++)
            {
                result.Add(_playerFactory.Create(position, team));
            }
            return result;
        }
    }
}