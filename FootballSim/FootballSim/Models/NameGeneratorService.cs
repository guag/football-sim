using System;

namespace FootballSim.Models
{

    public interface INameGeneratorService
    {
        string GetRandomFirstName();
        string GetRandomLastName();
    }

    public class NameGeneratorService : INameGeneratorService
    {
        public string GetRandomFirstName()
        {
            throw new NotImplementedException();
        }

        public string GetRandomLastName()
        {
            throw new NotImplementedException();
        }
    }
}