using System.Collections.Generic;
using FootballSim.Models.Players;

namespace FootballSim.Models.ViewModels
{
    public struct DraftClassViewModel
    {
        public IEnumerable<Player> Players { get; set; }
        public int Year { get; set; }
    }
}