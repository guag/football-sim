namespace FootballSim.Models.Ratings
{
    public interface IPlayerCaliberFactory
    {
        IPlayerCaliber CreateRandom();
    }

    public class PlayerCaliberFactory : IPlayerCaliberFactory
    {
        private readonly IRandomService _random;

        public PlayerCaliberFactory(IRandomService random)
        {
            _random = random;
        }

        #region IPlayerCaliberFactory Members

        public IPlayerCaliber CreateRandom()
        {
            int rand = _random.GetRandom(0, 100);
            if (rand < 5)
            {
                return new BlueChipCaliber();
            }
            if (rand < 21)
            {
                return new HighCaliber();
            }
            if (rand < 51)
            {
                return new AverageCaliber();
            }
            return new LowCaliber();
        }

        #endregion
    }
}