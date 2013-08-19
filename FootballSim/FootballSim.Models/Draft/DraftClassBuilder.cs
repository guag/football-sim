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
        private readonly IDraftBirthDateGenerator _birthDate;
        private readonly IPlayerBuilder _playerBuilder;

        public DraftClassBuilder(
            IPlayerBuilder playerBuilder, 
            IDraftClassFactory draftFactory, 
            IDraftBirthDateGenerator birthDate)
        {
            _playerBuilder = playerBuilder;
            _draftFactory = draftFactory;
            _birthDate = birthDate;
        }

        #region IDraftClassBuilder Members

        public IDraftClass Build(int year, int numPlayers)
        {
            IDraftClass draft = _draftFactory.Create(year);
            for (int i = 0; i < numPlayers; i++)
            {
                var player = _playerBuilder.Build();
                player.BirthDate = _birthDate.Generate(2013);
                draft.Players.Add(player);
            }
            return draft;
        }

        #endregion
    }
}