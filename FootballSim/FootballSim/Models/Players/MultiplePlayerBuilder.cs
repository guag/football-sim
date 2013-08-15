using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models.Players
{
    public interface IMultiplePlayerBuilder
    {
        IEnumerable<Player> Build(int numPlayers, Position position = null);
    }

    public class MultiplePlayerBuilder : IMultiplePlayerBuilder
    {
        private readonly IPlayerBuilder _playerBuilder;

        public MultiplePlayerBuilder(IPlayerBuilder playerBuilder)
        {
            _playerBuilder = playerBuilder;
        }

        #region IMultiplePlayerBuilder Members

        public IEnumerable<Player> Build(int numPlayers, Position position = null)
        {
            IList<Player> result = new List<Player>();
            for (int i = 0; i < numPlayers; i++)
            {
                result.Add(_playerBuilder.Build(position));
            }
            return result;
        }

        #endregion
    }
}