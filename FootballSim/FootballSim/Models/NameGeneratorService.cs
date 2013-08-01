using System;

namespace FootballSim.Models
{

    public interface INameGeneratorService
    {
        string GetRandomName();
    }

    public class NameGeneratorService : INameGeneratorService
    {
        public string GetRandomName()
        {
            throw new NotImplementedException();
        }
    }
}