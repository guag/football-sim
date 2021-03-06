using System.Collections.Generic;
using FootballSim.Models.Players;

namespace FootballSim.Models
{
    public interface ITeam
    {
        string City { get; set; }
        string Name { get; set; }
        IEnumerable<Player> Roster { get; set; }
        Location Location { get; set; }
    }
}