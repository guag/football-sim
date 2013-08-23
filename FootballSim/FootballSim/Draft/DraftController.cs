using System.Collections.Generic;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;

namespace FootballSim.Draft
{
    public interface IDraftController
    {
        IDraftClass CreateDraft(int year, int numPlayers);
        IList<Player> SortPlayers(IEnumerable<Player> players, string sortExpr = null);
    }

    public class DraftController : IDraftController
    {
        private readonly IDraftClassBuilder _draftBuilder;
        private readonly IDraftClassPlayerSorter _playerSorter;

        public DraftController(IDraftClassBuilder draftBuilder, IDraftClassPlayerSorter playerSorter)
        {
            _draftBuilder = draftBuilder;
            _playerSorter = playerSorter;
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

        public IDraftClass CreateDraft(int year, int numPlayers)
        {
            return _draftBuilder.Build(year, numPlayers);
        }

        #endregion
    }
}