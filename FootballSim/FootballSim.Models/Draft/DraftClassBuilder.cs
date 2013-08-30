using FootballSim.Models.Players;

namespace FootballSim.Models.Draft
{
    public interface IDraftClassBuilder
    {
        DraftClass Build(int year, int numPlayers);
    }

    public class DraftClassBuilder : IDraftClassBuilder
    {
        private readonly IDraftBirthDateGenerator _birthDate;
        private readonly IDraftClassFactory _draftFactory;
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

        public DraftClass Build(int year, int numPlayers)
        {
            DraftClass draft = _draftFactory.Create(year);
            for (int i = 0; i < numPlayers; i++)
            {
                Player player = _playerBuilder.Build();
                // TODO: remove the following line after adding the DB
                player.Id = i + 1;
                player.BirthDate = _birthDate.Generate(2013);
                draft.Players.Add(player);
            }
            return draft;
        }

        #endregion
    }
}