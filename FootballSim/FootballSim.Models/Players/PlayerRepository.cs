namespace FootballSim.Models.Players
{
    public interface IPlayerRepository
    {
    }

    public class PlayerRepository : IPlayerRepository
    {
        private readonly IFootballSimContext _context;

        public PlayerRepository(IFootballSimContext context)
        {
            _context = context;
        }
    }
}