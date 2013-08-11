using FootballSim.Models.Players;

namespace FootballSim.Models.Draft
{
    public interface IDraftClassFactory
    {
        IDraftClass Create(int year, int numPlayers);
    }

    public class DraftClassFactory : IDraftClassFactory
    {
        private readonly IMultiplePlayerBuilder _playerBuilder;

        public DraftClassFactory(IMultiplePlayerBuilder playerBuilder)
        {
            _playerBuilder = playerBuilder;
        }

        #region IDraftClassFactory Members

        public IDraftClass Create(int year, int numPlayers)
        {
            return new DraftClass
                       {
                           Players = _playerBuilder.Build(numPlayers),
                           Year = year
                       };
        }

        #endregion
    }
}