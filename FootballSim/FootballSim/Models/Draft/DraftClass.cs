using System.Collections.Generic;
using FootballSim.Models.Players;

namespace FootballSim.Models.Draft
{
    public interface IDraftClass
    {
        int Id { get; }
        IEnumerable<Player> Players { get; }
        int Year { get; }
    }

    public class DraftClass : IDraftClass
    {
        #region IDraftClass Members

        public int Id { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public int Year { get; set; }

        #endregion
    }
}