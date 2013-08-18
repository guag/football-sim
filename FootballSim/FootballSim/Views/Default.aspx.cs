using System;
using System.Web.UI;
using FootballSim.Models.Draft;
using Ninject;

namespace FootballSim.Views
{
    public partial class Default : Page
    {
        [Inject]
        public IDraftClassBuilder DraftBuilder { get; set; }

        protected void Page_Load(object sender, EventArgs e)
        {
            var draft = DraftBuilder.Build(2013, 500);
            Response.Write("Number of players: " + draft.Players.Count);
        }
    }
}