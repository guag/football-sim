using System.Collections.Generic;

namespace FootballSim.Models.ViewModels
{
    public struct DraftClassViewModel
    {
        public IEnumerable<Players.Player> Players { get; set; }
        public int Year { get; set; }
    }
}