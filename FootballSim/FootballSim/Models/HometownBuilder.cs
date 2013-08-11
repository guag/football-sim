using System.Collections.Generic;
using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IHometownBuilder : IPlayerBuildingBlock
    {
    }

    /// <summary>
    /// TODO: properly implement and test this class.
    /// </summary>
    public class HometownBuilder : IHometownBuilder
    {
        private readonly IRandomNumberService _randomService;

        public HometownBuilder(IRandomNumberService randomService)
        {
            _randomService = randomService;
        }

        private readonly IList<Location> _locations = new List<Location>
                                              {
                                                  new Location{ City = "Ronkonkoma", State = "NY" },
                                                  new Location{ City="Harrisburg", State="PA" },
                                                  new Location{ City="Dallas", State="TX" },
                                                  new Location{ City="St. Louis",State= "MO" },
                                                  new Location{ City="Sacramento", State= "CA" }
                                              };

        public void Build(Player player, IPosition position = null)
        {
            player.Hometown = _locations[_randomService.GetRandomInt(0, _locations.Count)];
        }
    }
}