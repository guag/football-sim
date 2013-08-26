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

        public void Build(Player player)
        {
            Location loc = _hometowns.GetRandomHometown();
            player.City = loc.City;
            player.State = loc.State;
        }

        #endregion
    }
}