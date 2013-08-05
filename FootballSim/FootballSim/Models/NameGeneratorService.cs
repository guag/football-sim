using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface INameGeneratorService
    {
        string GetRandomFirstName();
        string GetRandomLastName();
    }

    /// <summary>
    /// TODO: properly implement and test this class.
    /// </summary>
    public class NameGeneratorService : INameGeneratorService
    {
        private readonly IRandomNumberService _randomService;

        public NameGeneratorService(IRandomNumberService randomService)
        {
            _randomService = randomService;
        }

        private readonly IList<string> _firstNames = new List<string>
                                                {
                                                    "Gary",
                                                    "Carl",
                                                    "Steve",
                                                    "Marcos",
                                                    "Danny",
                                                    "Jacob",
                                                    "George",
                                                    "Tyrell",
                                                    "Kevin",
                                                    "Mike"
                                                };

        private readonly IList<string> _lastNames = new List<string>
                                                {
                                                    "Guagliardo",
                                                    "Brown",
                                                    "Brule",
                                                    "Flores",
                                                    "Orlando",
                                                    "Schmidt",
                                                    "Paul",
                                                    "Owens",
                                                    "Smith",
                                                    "Jones"
                                                };

        public string GetRandomFirstName()
        {
            return _firstNames[_randomService.GetRandomInt(0, _firstNames.Count)];
        }

        public string GetRandomLastName()
        {
            return _lastNames[_randomService.GetRandomInt(0, _lastNames.Count)];
        }
    }
}