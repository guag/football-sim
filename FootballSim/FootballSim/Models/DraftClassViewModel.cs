using System.Collections.Generic;

namespace FootballSim.Models
{
    public struct DraftClassViewModel
    {
        public IEnumerable<Player> Players { get; set; }
        public int Year { get; set; }
    }
}