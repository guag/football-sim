using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface ILeague
    {
        string Name { get; set; }
        IEnumerable<ITeam> Teams { get; set; }
    }
}