using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface ITeam
    {
        string City { get; set; }
        string Name { get; set; }
        IEnumerable<Player> Roster { get; set; }
        ILocation Location { get; set; }
    }
}