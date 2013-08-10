namespace FootballSim.Models
{
    public interface IPlayerFactory
    {
        Player Create();
    }

    public class PlayerFactory : IPlayerFactory
    {
        public Player Create()
        {
            return new Player();
        }
    }
}