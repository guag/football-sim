using System.Collections.Generic;

namespace FootballSim.Models.Players
{
    public interface ICollegeCache
    {
        string GetRandomCollege();
    }

    public class CollegeCache : ICollegeCache
    {
        private readonly ICsvFileLoader _loader;
        private readonly IRandomService _random;
        private IList<string> _collegeCache = new List<string>();

        public CollegeCache(IRandomService random, ICsvFileLoader loader)
        {
            _random = random;
            _loader = loader;
        }

        #region ICollegeCache Members

        public string GetRandomCollege()
        {
            if (_collegeCache.Count == 0)
            {
                _collegeCache = _loader.Colleges;
            }
            return _collegeCache[_random.GetRandom(_collegeCache.Count)];
        }

        #endregion
    }
}