using System;

namespace FootballSim.Models
{
    public interface IRandomNumberService
    {
        int GetRandomInt(int min, int max);
    }

    public class RandomNumberService : IRandomNumberService
    {
        private static readonly Random Random = new Random();

        public int GetRandomInt(int min, int max)
        {
            return Random.Next(min, max);
        }
    }
}