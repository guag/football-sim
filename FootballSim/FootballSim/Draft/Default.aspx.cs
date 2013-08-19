using System;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using FootballSim.Models.Draft;
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

            IDraftClass draft = DraftBuilder.Build(2013, 500);
            GrdPlayers.DataSource = draft.Players
                .OrderBy(p => p.Position.Type)
                .ThenByDescending(p => p.CurrentOverallRating)
                .ToList();
            GrdPlayers.DataBind();
        }

        protected void GrdPlayers_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
        }

        protected void GrdPlayers_Sorting(object sender, GridViewSortEventArgs e)
        {
        }
    }
}