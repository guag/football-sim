using FootballSim.Models.Players;

namespace FootballSim.Models.Draft
{
    public interface IDraftClassBuilder
    {
        IDraftClass Build(int year, int numPlayers);
    }

    public class DraftClassBuilder : IDraftClassBuilder
    {
        private readonly IDraftClassFactory _draftFactory;
        private readonly IPlayerBuilder _playerBuilder;

        public DraftClassBuilder(IPlayerBuilder playerBuilder, IDraftClassFactory draftFactory)
        {
            _playerBuilder = playerBuilder;
            _draftFactory = draftFactory;
        }

        #region IDraftClassBuilder Members

        public IDraftClass Build(int year, int numPlayers)
        {
            IDraftClass draft = _draftFactory.Create(year);
            for (int i = 0; i < numPlayers; i++)
            {
                draft.Players.Add(_playerBuilder.Build());
            }
            return draft;
        }

        #endregion
    }
}