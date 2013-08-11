using System;

namespace FootballSim.Models
{
    public interface IRandomService
    {
        int GetRandom(int max);
        int GetRandom(int min, int max);
    }

    public class RandomService : IRandomService
    {
        private static readonly Random Random = new Random();

        #region IRandomNumberService Members

        public int GetRandom(int max)
        {
            return Random.Next(max);
        }

        public int GetRandom(int min, int max)
        {
            return Random.Next(min, max);
        }

        #endregion
    }
}