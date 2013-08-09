using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface IHometownRepository
    {
        Location GetRandomHometown();
    }

    /// <summary>
    /// TODO: properly implement and test this class.
    /// </summary>
    public class HometownRepository : IHometownRepository
    {
        private readonly IRandomNumberService _randomService;

        public HometownRepository(IRandomNumberService randomService)
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

        public Location GetRandomHometown()
        {
            return _locations[_randomService.GetRandomInt(0, _locations.Count)];
        }
    }
}