using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using FootballSim.Models;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using Ninject;

namespace FootballSim.Draft
{
    public partial class Default : Page
    {
        [Inject]
        public IDraftController DraftController { get; set; }

        public IList<Player> Players
        {
            get { return (IList<Player>)ViewState["Players"]; }
            set { ViewState["Players"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                return;
            }
            IDraftClass draft = DraftController.CreateDraft(2006, 300);
            Players = DraftController.SortPlayers(draft.Players);
        }

        /// <summary>
        /// TODO: this logic can be moved to the controller.
        /// </summary>
        public IList<Player> GetPlayers(string sortExpr)
        {
            return DraftController.SortPlayers(Players, sortExpr);
        }
    }
}