using System;

namespace FootballSim.Models
{
    public interface IRandomNumberService
    {
        int GetRandomInt(int max);
    }

    public class RandomNumberService : IRandomNumberService
    {
        private static readonly Random Random = new Random();

        #region IRandomNumberService Members

        public int GetRandomInt(int max)
        {
            return Random.Next(0, max);
        }

        #endregion
    }
}