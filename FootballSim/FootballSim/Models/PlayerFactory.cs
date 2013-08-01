using System;

namespace FootballSim.Models
{
    public interface IPlayerFactory
    {
        IPlayer Create(IPosition position);
    }

    public class PlayerFactory : IPlayerFactory
    {
        private readonly INameGeneratorService _nameGenerator;

        public PlayerFactory(INameGeneratorService nameGenerator)
        {
            _nameGenerator = nameGenerator;
        }

        public IPlayer Create(IPosition position)
        {
            throw new NotImplementedException();
        }
    }
}