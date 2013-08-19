using System;
using System.Linq;
using System.Web.UI;
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
            IDraftClass draft = DraftBuilder.Build(2013, 500);

            GrdPlayers.DataSource = draft.Players
                .OrderBy(p => p.Position.Type)
                .ThenByDescending(p => p.CurrentOverallRating);
            GrdPlayers.DataBind(); 
        }
    }
}