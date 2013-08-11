using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace FootballSim.Models
{
    public interface IRandomCollegeRetriever
    {
        string GetRandomCollege();
    }

    public class RandomCollegeRetriever : IRandomCollegeRetriever
    {
        private readonly ICsvFileLoader _loader;
        private readonly IRandomNumberService _randomService;
        private IList<string> _collegeCache = new List<string>();

        public RandomCollegeRetriever(IRandomNumberService randomService, ICsvFileLoader loader)
        {
            _randomService = randomService;
            _loader = loader;
        }

        #region IRandomCollegeRetriever Members

        public string GetRandomCollege()
        {
            if (_collegeCache.Count == 0)
            {
                _collegeCache = _loader.Colleges.ToList();
                var builder = new StringBuilder();
                foreach (var college in _collegeCache)
                {
                    builder.AppendFormat("{0}|", college);
                }
                Debug.Write(builder.ToString());
            }
            return _collegeCache[_randomService.GetRandomInt(0, _collegeCache.Count)];
        }

        #endregion
    }
}