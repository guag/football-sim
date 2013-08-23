using System;
using System.Collections.Generic;
using System.Linq;
using FootballSim.Models.Players;

namespace FootballSim.Models.Draft
{
    public interface IDraftClassPlayerSorter
    {
        IList<Player> Sort(
            IEnumerable<Player> players, string expr = null, string order = null);
    }

    public class DraftClassPlayerSorter : IDraftClassPlayerSorter
    {
        #region IDraftClassPlayerSorter Members

        public IList<Player> Sort(IEnumerable<Player> players,
                                  string expr = null, string order = null)
        {
            if (expr == null)
            {
                return players
                    .OrderBy(p => p.Position.Type)
                    .ThenByDescending(p => p.CurrentOverallRating)
                    .ToList();
            }

            return players.OrderBy(GetSortingFunc(expr), order).ToList();
        }

        #endregion

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