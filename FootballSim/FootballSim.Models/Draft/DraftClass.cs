using System.Collections.Generic;
using FootballSim.Models.Players;

namespace FootballSim.Models.Draft
{
    public interface IDraftClass
    {
        int Id { get; }
        IList<Player> Players { get; }
        int Year { get; }
    }

    public class DraftClass : IDraftClass
    {
        private readonly IList<Player> _players = new List<Player>();

        #region IDraftClass Members

        public int Id { get; set; }
        public int Year { get; set; }

        public IList<Player> Players
        {
            get { return _players; }
        }

        #endregion
    }
}