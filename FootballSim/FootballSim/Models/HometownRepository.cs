using System;

namespace FootballSim.Models
{
    public interface IHometownRepository
    {
        ILocation GetRandomHometown();
    }

    public class HometownRepository : IHometownRepository
    {
        public ILocation GetRandomHometown()
        {
            throw new NotImplementedException();
        }
    }
}