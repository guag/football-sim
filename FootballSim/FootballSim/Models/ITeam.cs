using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface ITeam
    {
        string City { get; set; }
        string Name { get; set; }
        IEnumerable<Players.Player> Roster { get; set; }
        Location Location { get; set; }
    }
}