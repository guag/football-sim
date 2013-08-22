using System;
using System.Collections.Generic;
using System.Web.UI;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using Ninject;

namespace FootballSim.Draft
{
    public partial class Default : Page
    {
        [Inject]
        public IDraftController DraftController
        {
            get { return (IDraftController) Session["DraftController"]; }
            set { Session["DraftController"] = value; }
        }

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
            IDraftClass draft = DraftController.CreateDraft(2006, 300);
            Players = DraftController.SortPlayers(draft.Players);
        }

        public IList<Player> GetPlayers(string sortExpr)
        {
            return DraftController.SortPlayers(Players, sortExpr);
        }
    }
}