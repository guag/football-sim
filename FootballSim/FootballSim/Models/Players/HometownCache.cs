using System.Collections.Generic;

namespace FootballSim.Models.Players
{
    public interface IHometownCache
    {
        Location GetRandomHometown();
    }

    public class HometownCache : IHometownCache
    {
        private readonly ICsvFileLoader _loader;
        private readonly IRandomNumberService _random;
        private IList<Location> _hometowns = new List<Location>();

        public HometownCache(ICsvFileLoader loader, IRandomNumberService random)
        {
            _loader = loader;
            _random = random;
        }

        #region IHometownCache Members

        public Location GetRandomHometown()
        {
            if (_hometowns.Count == 0)
            {
                _hometowns = _loader.Hometowns;
            }
            return _hometowns[_random.GetRandomInt(_hometowns.Count)];
        }

        #endregion
    }
}