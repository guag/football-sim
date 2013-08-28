using System.Collections.Generic;
using System.Linq;

namespace FootballSim.Models.Ratings
{
    public interface IPlayerCaliberRepository
    {
        PlayerCaliber GetRandom();
    }

    public class PlayerCaliberRepository : IPlayerCaliberRepository
    {
        private readonly ISet<PlayerCaliber> _calibers = new HashSet<PlayerCaliber>();

        private readonly IFootballSimContext _db;
        private readonly IRandomService _random;

        public PlayerCaliberRepository(IRandomService random, IFootballSimContext db)
        {
            _random = random;
            _db = db;
        }

        #region IPlayerCaliberRepository Members

        public PlayerCaliber GetRandom()
        {
            LoadCache();
            int rand = _random.GetRandom(0, 100);
            if (rand < 5)
            {
                return _calibers.First(c => c.GetType() == typeof (BlueChipCaliber));
            }
            if (rand < 21)
            {
                return _calibers.First(c => c.GetType() == typeof (HighCaliber));
            }
            return (rand < 51)
                       ? _calibers.First(c => c.GetType() == typeof (AverageCaliber))
                       : _calibers.First(c => c.GetType() == typeof (LowCaliber));
        }

        #endregion

        /// <summary>
        /// TODO: test this
        /// </summary>
        private void LoadCache()
        {
            if (_calibers.Count > 0)
            {
                return;
            }

            foreach (PlayerCaliber caliber in 
                _db.Calibers.Where(caliber => !_calibers.Contains(caliber)))
            {
                _calibers.Add(caliber);
            }

            if (_calibers.Count > 0)
            {
                return;
            }

            // TODO: replace object creation here with a factory
            _calibers.Add(new BlueChipCaliber());
            _calibers.Add(new HighCaliber());
            _calibers.Add(new AverageCaliber());
            _calibers.Add(new LowCaliber());
        }
    }
}