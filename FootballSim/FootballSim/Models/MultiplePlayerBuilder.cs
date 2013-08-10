using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IMultiplePlayerBuilder
    {
        IEnumerable<Player> Build(int numPlayers, IPosition position = null);
    }

    public class MultiplePlayerBuilder : IMultiplePlayerBuilder
    {
        private readonly IPlayerBuilder _playerBuilder;

        public MultiplePlayerBuilder(IPlayerBuilder playerBuilder)
        {
            _playerBuilder = playerBuilder;
        }

        public IEnumerable<Player> Build(int numPlayers, IPosition position = null)
        {
            IList<Player> result = new List<Player>();
            for (var i = 0; i < numPlayers; i++)
            {
                result.Add(_playerBuilder.Build(position));
            }
            return result;
        }
    }
}