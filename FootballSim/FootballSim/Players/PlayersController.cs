using System;
using FootballSim.Models.Players;

namespace FootballSim.Players
{
    public interface IPlayersController : IController
    {
        Player GetPlayer(int id);
    }

    public class PlayersController : IPlayersController
    {
        #region IPlayersController Members

        /// <summary>
        /// TODO: test this
        /// </summary>
        public Player GetPlayer(int id)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}