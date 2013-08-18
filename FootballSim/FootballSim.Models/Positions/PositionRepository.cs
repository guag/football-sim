using System.Collections.Generic;

namespace FootballSim.Models.Positions
{
    public interface IPositionRepository
    {
        Position GetRandomPosition();
    }

    public class PositionRepository : IPositionRepository
    {
        private readonly Position _emptyPosition = new EmptyPosition();
        private readonly IList<Position> _positions = new List<Position>();
        private readonly IRandomService _random;

        public PositionRepository(IRandomService random)
        {
            _random = random;
        }

        #region IPositionRepository Members

        public Position GetRandomPosition()
        {
            return (_positions.Count == 0
                        ? _emptyPosition
                        : _positions[_random.GetRandom(_positions.Count)]);
        }

        #endregion

        public void AddPosition(Position position)
        {
            _positions.Add(position);
        }
    }
}