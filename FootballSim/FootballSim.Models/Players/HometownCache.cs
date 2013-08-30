using System.Collections.Generic;

namespace FootballSim.Models.Players
{
    public interface IHometownCache
    {
        Location GetRandomHometown();
    }

    public class HometownCache : IHometownCache
    {
        private readonly IList<Location> _cache = new List<Location>();
        private readonly ICsvFileLoader _loader;
        private readonly IRandomService _random;

        public HometownCache(ICsvFileLoader loader, IRandomService random)
        {
            _loader = loader;
            _random = random;
        }

        #region IHometownCache Members

        public Location GetRandomHometown()
        {
            if (_cache.Count == 0)
            {
                foreach (string[] loc in _loader.Hometowns)
                {
                    _cache.Add(new Location {City = loc[0], State = loc[1]});
                }
            }
            return _cache[_random.GetRandom(_cache.Count)];
        }

        #endregion
    }
}