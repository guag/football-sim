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
        private readonly IRandomNumberService _randomService;
        private IList<string> _collegeCache = new List<string>();

        public CollegeCache(IRandomNumberService randomService, ICsvFileLoader loader)
        {
            _randomService = randomService;
            _loader = loader;
        }

        #region ICollegeCache Members

        public string GetRandomCollege()
        {
            if (_collegeCache.Count == 0)
            {
                _collegeCache = _loader.Colleges;
            }
            return _collegeCache[_randomService.GetRandomInt(_collegeCache.Count)];
        }

        #endregion
    }
}