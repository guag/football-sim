using System.Collections.Generic;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;

namespace FootballSim.Draft
{
    public interface IDraftController : IController
    {
        DraftClass CreateDraft(int year, int numPlayers);
        IList<Player> SortPlayers(IEnumerable<Player> players, string sortExpr = null);
        void SaveDraft(DraftClass draft);
        DraftClass GetDraft(int id);
    }

    public class DraftController : IDraftController
    {
        private readonly IDraftClassBuilder _draftBuilder;
        private readonly IDraftClassPlayerSorter _playerSorter;
        private readonly IDraftClassRepository _repository;

        public DraftController(IDraftClassBuilder draftBuilder, IDraftClassPlayerSorter playerSorter,
            IDraftClassRepository repository)
        {
            _draftBuilder = draftBuilder;
            _playerSorter = playerSorter;
            _repository = repository;
        }

        #region IDraftController Members

        public IList<Player> SortPlayers(IEnumerable<Player> players, string sortExpr = null)
        {
            if (string.IsNullOrEmpty(sortExpr))
            {
                return _playerSorter.Sort(players);
            }

            string[] arrExpr = sortExpr.Split(' ');
            string order;
            try
            {
                order = arrExpr[1];
            }
            catch
            {
                order = string.Empty;
            }

            return _playerSorter.Sort(players, arrExpr[0], order);
        }

        /// <summary>
        /// TODO: test this
        /// </summary>
        public void SaveDraft(DraftClass draft)
        {
            _repository.AddDraft(draft);
        }

        /// <summary>
        /// TODO: test this 
        /// </summary>
        public DraftClass GetDraft(int id)
        {
            return _repository.GetDraft(id);
        }

        public DraftClass CreateDraft(int year, int numPlayers)
        {
            return _draftBuilder.Build(year, numPlayers);
        }

        #endregion
    }
}