using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface IHometownRepository
    {
        ILocation GetRandomHometown();
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

        private readonly IList<ILocation> _locations = new List<ILocation>
                                              {
                                                  new Location("Ronkonkoma", "NY"),
                                                  new Location("Harrisburg", "PA"),
                                                  new Location("Dallas", "TX"),
                                                  new Location("St. Louis", "MO"),
                                                  new Location("Sacramento", "CA")
                                              };

        public ILocation GetRandomHometown()
        {
            return _locations[_randomService.GetRandomInt(0, _locations.Count)];
        }
    }
}