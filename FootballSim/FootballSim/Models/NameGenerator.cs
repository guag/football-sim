using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface INameGenerator : IPlayerBuildingBlock
    {
    }

    /// <summary>
    /// TODO: properly implement and test this class.
    /// </summary>
    public class NameGenerator : INameGenerator
    {
        private readonly IRandomNumberService _randomService;

        public NameGenerator(IRandomNumberService randomService)
        {
            _randomService = randomService;
        }

        private readonly IList<string> _firstNames = 
            new List<string>
            {
                "Gary",
                "Carl",
                "Steve",
                "Marcos",
                "Danny",
                "Jacob",
                "George",
                "Tyrell",
                "Kevin",
                "Mike"
            };

        private readonly IList<string> _lastNames = 
            new List<string>
            {
                "Guagliardo",
                "Brown",
                "Brule",
                "Flores",
                "Orlando",
                "Schmidt",
                "Paul",
                "Owens",
                "Smith",
                "Jones"
            };

        public void Build(Player player, IPosition position = null)
        {
            player.FirstName = _firstNames[_randomService.GetRandomInt(0, _firstNames.Count)];
            player.LastName = _lastNames[_randomService.GetRandomInt(0, _lastNames.Count)];
        }
    }
}