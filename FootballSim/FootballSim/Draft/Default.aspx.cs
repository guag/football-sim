using System;
using System.Collections.Generic;
using System.Globalization;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;

namespace FootballSim.Draft
{
    public partial class Default : View<IDraftController>
    {
        public IList<Player> Players
        {
            get { return (IList<Player>) Session["Players"]; }
            set { Session["Players"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }
            // TODO: replace this with a DB load
            IDraftClass draft = Controller.CreateDraft(2006, 300);
            Players = Controller.SortPlayers(draft.Players);

            lblTitle.Text = draft.Year.ToString(CultureInfo.InvariantCulture);
        }

        public IList<Player> GetPlayers(string sortExpr)
        {
            return Controller.SortPlayers(Players, sortExpr);
        }
    }
}