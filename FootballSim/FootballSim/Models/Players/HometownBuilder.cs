using FootballSim.Models.Positions;

namespace FootballSim.Models.Players
{
    public interface IHometownBuilder : IPlayerBuildingBlock
    {
    }

    public class HometownBuilder : IHometownBuilder
    {
        private readonly IHometownCache _hometowns;

        public HometownBuilder(IHometownCache hometowns)
        {
            _hometowns = hometowns;
        }

        #region IHometownBuilder Members

        public void Build(Player player, Position position = null)
        {
            player.Hometown = _hometowns.GetRandomHometown();
        }

        #endregion
    }
}