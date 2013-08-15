using System;
using System.Diagnostics;

namespace FootballSim.Models
{
    public interface IRandomService
    {
        int GetRandom(int max);
        int GetRandom(int min, int max);
        int GetRandomWeighted(int min, int max);
    }

    public class RandomService : IRandomService
    {
        private static readonly Random Random = new Random();
        private static readonly Random RandomAlt = new Random();

        #region IRandomService Members

        public int GetRandom(int max)
        {
            return Random.Next(max);
        }

        public int GetRandom(int min, int max)
        {
            if (min > max)
            {
                Debug.WriteLine("min: " + min + ", max: " + max);
            }
            return Random.Next(min, max);
        }

        public int GetRandomWeighted(int min, int max)
        {
            int diff = max - min;
            var oneQuarter = diff*0.25;
            var at25Per = min + (int) oneQuarter;
            int at75Per = max - (int)oneQuarter;

            int rand = RandomAlt.Next(0, 6);
            if (rand > 0 && rand < 5)
            {
                return GetRandom(at25Per + 1, at75Per);
            }
            return (rand == 0)
                       ? GetRandom(min, at25Per)
                       : GetRandom(at75Per + 1, max);
        }

        #endregion
    }
}