using System;
using FootballSim.Models.Players;

namespace FootballSim.Players
{
    public partial class ViewPlayer : View<IPlayersController>
    {
        public Player Player
        {
            get { return (Player) Session["CurrentPlayer"]; }
            set { Session["CurrentPlayer"] = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                return;
            }

            Player = LoadPlayer();
            lblName.Text = Player.FullName;
        }

        private Player LoadPlayer()
        {
            int id;
            if (!int.TryParse(Request.QueryString["id"], out id))
            {
                throw new Exception("'id' is not a valid number");
            }
            return Controller.GetPlayer(id);
        }
    }
}