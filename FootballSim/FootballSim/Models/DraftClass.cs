using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface IDraftClass
    {
        int Id { get; }
        IEnumerable<Player> Players { get; }
        int Year { get; }
    }

    public class DraftClass : IDraftClass
    {
        public int Id { get; set; }
        public IEnumerable<Player> Players { get; set; }
        public int Year { get; set; }
    }
}