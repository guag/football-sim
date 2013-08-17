using FootballSim.Models.Ratings;

namespace FootballSim.Models.Players
{
    public interface IPlayerCaliberBuilder : IPlayerBuildingBlock
    {
    }

    public class PlayerCaliberBuilder : IPlayerCaliberBuilder
    {
        private readonly IPlayerCaliberFactory _caliber;

        public PlayerCaliberBuilder(IPlayerCaliberFactory caliber)
        {
            _caliber = caliber;
        }

        #region IPlayerBuildingBlock Members

        public void Build(Player player)
        {
            player.Caliber = _caliber.CreateRandom();
        }

        #endregion
    }
}