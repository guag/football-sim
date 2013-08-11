using System;

namespace FootballSim.Models
{
    public interface IRandomService
    {
        int GetRandom(int max);
    }

    public class RandomService : IRandomService
    {
        private static readonly Random Random = new Random();

        #region IRandomNumberService Members

        public int GetRandom(int max)
        {
            return Random.Next(0, max);
        }

        #endregion
    }
}