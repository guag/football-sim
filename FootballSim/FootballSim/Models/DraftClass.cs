using System;
using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface IDraftClass
    {
        IEnumerable<Player> Players { get; }
        DateTime Year { get; }
    }

    public class DraftClass : IDraftClass
    {
        public IEnumerable<Player> Players { get; private set; }
        public DateTime Year { get; private set; }

        public DraftClass(IEnumerable<Player> players, DateTime year)
        {
            Players = players;
            Year = year;
        }
    }
}