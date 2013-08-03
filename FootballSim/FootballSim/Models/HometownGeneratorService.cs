using System;

namespace FootballSim.Models
{
    public interface IHometownGeneratorService
    {
        ILocation GetRandomHometown();
    }

    public class HometownGeneratorService : IHometownGeneratorService
    {
        public ILocation GetRandomHometown()
        {
            throw new NotImplementedException();
        }
    }
}