using System;
using System.Collections.Generic;

namespace FootballSim.Models.Ratings
{
    public interface IPlayerCaliberRepository
    {
        PlayerCaliber GetRandom();
    }

    public class PlayerCaliberRepository : IPlayerCaliberRepository
    {
        private readonly IDictionary<Type, PlayerCaliber> _cache =
            new Dictionary<Type, PlayerCaliber>();

        private readonly IRandomService _random;

        public PlayerCaliberRepository(IRandomService random)
        {
            _random = random;
        }

        #region IPlayerCaliberRepository Members

        public PlayerCaliber GetRandom()
        {
            int rand = _random.GetRandom(0, 100);
            if (rand < 5)
            {
                return _cache[typeof (BlueChipCaliber)];
            }
            if (rand < 21)
            {
                return _cache[typeof (HighCaliber)];
            }
            return (rand < 51)
                       ? _cache[typeof (AverageCaliber)]
                       : _cache[typeof (LowCaliber)];
        }

        #endregion

        public void Add<T>(PlayerCaliber caliber) where T : PlayerCaliber
        {
            _cache.Add(typeof(T), caliber);
        }
    }
}