using System.Collections.Generic;

namespace FootballSim.Models
{
    /// <summary>
    /// Ugly, untestable code.
    /// </summary>
    public interface ICsvFileLoader
    {
        IList<string> FirstNames { get; }
        IList<string> LastNames { get; }
        IList<string> Colleges { get; }
        IList<string[]> Hometowns { get; }
    }
}