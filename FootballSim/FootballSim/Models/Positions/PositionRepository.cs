using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballSim.Models.Positions
{
    public interface IPositionRepository
    {
        IPosition GetRandomPosition();
        IPosition GetPosition(PositionType type);
    }

    public class PositionRepository : IPositionRepository
    {
        private readonly IList<IPosition> _positions = new List<IPosition>();
        private readonly IPosition _emptyPosition = new EmptyPosition();

        public void AddPosition(IPosition positionClass)
        {
            _positions.Add(positionClass);
        }

        /// <summary>
        /// Returns an instance of a position picked at random from the internal list.
        /// </summary>
        /// <returns>The random position</returns>
        public IPosition GetRandomPosition()
        {
            if (_positions.Count == 0)
            {
                return _emptyPosition;
            }
            var rand = new Random().Next(0, _positions.Count - 1);
            return _positions[rand];
        }

        /// <summary>
        /// Returns the position with the given type name.
        /// </summary>
        /// <param name="type">The name of the type to retrieve</param>
        /// <returns>The position</returns>
        public IPosition GetPosition(PositionType type)
        {
            return _positions.FirstOrDefault(p => p.Type == type) ?? _emptyPosition;
        }
    }
}