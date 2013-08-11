using System.Collections.Generic;

namespace FootballSim.Models.Players
{
    public interface INameCache
    {
        string GetRandomFirstName();
        string GetRandomLastName();
    }

    public class NameCache : INameCache
    {
        public static string EmptyName = "Empty";
        private readonly ICsvFileLoader _loader;
        private readonly IRandomNumberService _randomService;
        private IList<string> _firstNameCache = new List<string>();
        private IList<string> _lastNameCache = new List<string>();

        public NameCache(ICsvFileLoader loader, IRandomNumberService randomService)
        {
            _loader = loader;
            _randomService = randomService;
        }

        #region INameCache Members

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
            return names.Count == 0 ? EmptyName : names[_randomService.GetRandomInt(names.Count)];
        }
    }
}