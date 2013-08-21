using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballSim.Models;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using Ninject;

namespace FootballSim.Draft
{
    public partial class Default : Page
    {
        [Inject]
        public IDraftClassBuilder DraftBuilder { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            IDraftClass draft = DraftBuilder.Build(2013, 250);
            Session["Players"] = DefaultSorted(draft.Players);
        }

        public IList<Player> GetPlayers(string sortExpr = "FullName")
        {
            var players = (IList<Player>) Session["Players"];

            if (string.IsNullOrEmpty(sortExpr))
            {
                return DefaultSorted(players);
            }

            var split = sortExpr.Split(' ');
            var expr = split[0];
            var order = (split.Length == 1) ? string.Empty : split[1];
            if (expr.Equals("FullName"))
            {
                return players.OrderBy(p => p.FullName, order).ToList();
            }
            if (expr.Equals("Position"))
            {
                return players.OrderBy(p => p.Position.Type, order).ToList();
            }
            if (expr.Equals("Caliber"))
            {
                return players.OrderBy(p => p.Caliber.MaxValue, order).ToList();
            }
            throw new ArgumentException("sortExpr");
        }

        private static List<Player> DefaultSorted(IEnumerable<Player> players)
        {
            return players.
                OrderBy(p => p.Position.Type)
                .ThenByDescending(p => p.CurrentOverallRating)
                .ToList();
        }

        protected void GrdPlayers_Sorting(object sender, GridViewSortEventArgs e)
        {
            // TODO: do we need this?
        }
    }
}