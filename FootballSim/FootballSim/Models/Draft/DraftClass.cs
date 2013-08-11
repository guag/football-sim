using System.Collections.Generic;

namespace FootballSim.Models.Draft
{
    public interface IDraftClass
    {
        int Id { get; }
        IEnumerable<Players.Player> Players { get; }
        int Year { get; }
    }

    public class DraftClass : IDraftClass
    {
        #region IDraftClass Members

        public int Id { get; set; }
        public IEnumerable<Players.Player> Players { get; set; }
        public int Year { get; set; }

        #endregion
    }
}