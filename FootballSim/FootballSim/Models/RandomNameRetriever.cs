using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface IRandomNameRetriever
    {
        string GetRandomFirstName();
        string GetRandomLastName();
    }

    public class RandomNameRetriever : IRandomNameRetriever
    {
        public static string EmptyName = "Empty";
        private readonly ICsvFileLoader _loader;
        private readonly IRandomNumberService _randomService;
        private IList<string> _firstNameCache = new List<string>();
        private IList<string> _lastNameCache = new List<string>();

        public RandomNameRetriever(ICsvFileLoader loader, IRandomNumberService randomService)
        {
            _loader = loader;
            _randomService = randomService;
        }

        #region INameRetriever Members

        public string GetRandomFirstName()
        {
            if (_firstNameCache.Count == 0)
            {
                _firstNameCache = _loader.FirstNames;
            }
            return GetRandomName(_firstNameCache);
        }

        public string GetRandomLastName()
        {
            if (_lastNameCache.Count == 0)
            {
                _lastNameCache = _loader.LastNames;
            }
            return GetRandomName(_lastNameCache);
        }

        #endregion

        private string GetRandomName(IList<string> names)
        {
            return names.Count == 0 ? EmptyName : names[_randomService.GetRandomInt(0, names.Count)];
        }
    }
}