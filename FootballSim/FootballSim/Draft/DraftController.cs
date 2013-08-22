using System;
using System.Collections.Generic;
using System.Linq;
using FootballSim.Models;
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

        public DraftController(IDraftClassBuilder draftBuilder)
        {
            _draftBuilder = draftBuilder;
        }

        #region IDraftController Members

        /// <summary>
        /// TODO: test this
        /// </summary>
        public IList<Player> SortPlayers(IEnumerable<Player> players, string sortExpr = null)
        {
            if (string.IsNullOrEmpty(sortExpr))
            {
                // TODO: move to separate class
                //return players
                //    .OrderBy(p => p.Position.Type)
                //    .ThenByDescending(p => p.CurrentOverallRating)
                //    .ToList();
            }

            string[] arrExpr = sortExpr.Split(' ');
            string order = (arrExpr.Length == 1) ? string.Empty : arrExpr[1];
            throw new NotImplementedException();
            // TODO: move to separate class
            //return players.OrderBy(GetSortingFunc(arrExpr[0]), order).ToList();
        }

        public IDraftClass CreateDraft(int year, int numPlayers)
        {
            return _draftBuilder.Build(year, numPlayers);
        }

        #endregion

        /// <summary>
        /// TODO: move to separate class
        /// </summary>
        /// <param name="expr"></param>
        /// <returns></returns>
        private static Func<Player, object> GetSortingFunc(string expr)
        {
            if (expr.Equals("FullName"))
            {
                return p => p.FullName;
            }
            if (expr.Equals("Position"))
            {
                return p => p.Position.Type;
            }
            if (expr.Equals("Caliber"))
            {
                return p => p.Caliber.MaxValue;
            }
            if (expr.Equals("College"))
            {
                return p => p.College;
            }
            throw new ArgumentException("expr");
        }
    }
}