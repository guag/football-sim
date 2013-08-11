namespace FootballSim.Models.Players
{
    public interface IPlayerFactory
    {
        Player Create();
    }

    public class PlayerFactory : IPlayerFactory
    {
        #region IPlayerFactory Members

        public Player Create()
        {
            return new Player();
        }

        #endregion
    }
}