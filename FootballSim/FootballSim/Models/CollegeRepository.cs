using System;

namespace FootballSim.Models
{
    public interface ICollegeRepository
    {
        string GetRandomCollege();
    }

    public class CollegeRepository : ICollegeRepository
    {
        public string GetRandomCollege()
        {
            throw new NotImplementedException();
        }
    }
}
