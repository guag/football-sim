using System.Collections.Generic;

namespace FootballSim.Models.Positions
{
    public interface IPositionRepository
    {
        IPosition GetRandomPosition();
    }

    public class PositionRepository : IPositionRepository
    {
        private readonly IPosition _emptyPosition = new EmptyPosition();
        private readonly IList<IPosition> _positions = new List<IPosition>();
        private readonly IRandomService _random;

        public PositionRepository(IRandomService random)
        {
            _random = random;
        }

        #region IPositionRepository Members

        public IPosition GetRandomPosition()
        {
            return (_positions.Count == 0
                        ? _emptyPosition
                        : _positions[_random.GetRandom(_positions.Count)]);
        }

        #endregion

        public void AddPosition(IPosition position)
        {
            _positions.Add(position);
        }
    }
}