using FootballSim.Models.Ratings;

namespace FootballSim.Models.Players
{
    public interface IPlayerCaliberBuilder : IPlayerBuildingBlock
    {
    }

    public class PlayerCaliberBuilder : IPlayerCaliberBuilder
    {
        private readonly IPlayerCaliberRepository _caliber;

        public PlayerCaliberBuilder(IPlayerCaliberRepository caliber)
        {
            _caliber = caliber;
        }

        #region IPlayerCaliberBuilder Members

        public void Build(Player player)
        {
            player.Caliber = _caliber.GetRandom();
        }

        #endregion
    }
}