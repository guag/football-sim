using System.Collections.Generic;

namespace FootballSim.Models
{
    public interface ICollegeRepository
    {
        string GetRandomCollege();
    }

    /// <summary>
    /// TODO: Properly implement and test this class.
    /// </summary>
    public class CollegeRepository : ICollegeRepository
    {
        private readonly IRandomNumberService _randomSercice;

        public CollegeRepository(IRandomNumberService randomSercice)
        {
            _randomSercice = randomSercice;
        }

        private readonly IList<string> _colleges = new List<string>
                                              {
                                                  "SBU",
                                                  "Texas",
                                                  "Rutgers",
                                                  "Penn State",
                                                  "TCU"
                                              };

        public string GetRandomCollege()
        {
            return _colleges[_randomSercice.GetRandomInt(0, _colleges.Count)];
        }
    }
}
