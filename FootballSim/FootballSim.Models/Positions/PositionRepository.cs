using System.Collections.Generic;

namespace FootballSim.Models.Positions
{
    public interface IPositionRepository
    {
        Position GetRandomPosition();
    }

    public class PositionRepository : IPositionRepository
    {
        private readonly IList<Position> _cache = new List<Position>();
        private readonly IRandomService _random;

        public PositionRepository(IRandomService random)
        {
            _random = random;
        }

        #region IPositionRepository Members

        public Position GetRandomPosition()
        {
            return _cache[_random.GetRandom(_cache.Count)];
        }

        #endregion

        public void AddPosition(Position position)
        {
            _cache.Add(position);
        }
    }
}