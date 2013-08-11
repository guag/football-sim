using System.Collections.Generic;
using System.Diagnostics;

namespace FootballSim.Models
{
    public interface INameRetriever
    {
        string GetRandomFirstName();
        string GetRandomLastName();
    }

    public class NameRetriever : INameRetriever
    {
        public static string EmptyName = "Empty";
        private readonly INameFilesLoader _loader;
        private readonly IRandomNumberService _randomService;
        private IList<string> _firstNames = new List<string>();
        private IList<string> _lastNames = new List<string>();

        public NameRetriever(INameFilesLoader loader, IRandomNumberService randomService)
        {
            _loader = loader;
            _randomService = randomService;
        }

        #region INameRetriever Members

        public string GetRandomFirstName()
        {
            if (_firstNames.Count == 0)
            {
                _firstNames = _loader.FirstNames;
            }
            return GetRandomName(_firstNames);
        }

        public string GetRandomLastName()
        {
            if (_lastNames.Count == 0)
            {
                _lastNames = _loader.LastNames;
                foreach (var lastName in _lastNames)
                {
                    Debug.Write(lastName[0] + lastName.Substring(1).ToLower() + ",");
                }
            }
            return GetRandomName(_lastNames);
        }

        #endregion

        private string GetRandomName(IList<string> names)
        {
            return names.Count == 0 ? EmptyName : names[_randomService.GetRandomInt(0, names.Count)];
        }
    }
}