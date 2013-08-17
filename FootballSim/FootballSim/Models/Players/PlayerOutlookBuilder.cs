namespace FootballSim.Models.Players
{
    public interface IPlayerOutlookBuilder : IPlayerBuildingBlock
    {
    }

    public class PlayerOutlookBuilder : IPlayerOutlookBuilder
    {
        private readonly IOutlookGenerator _outlook;

        public PlayerOutlookBuilder(IOutlookGenerator outlook)
        {
            _outlook = outlook;
        }

        #region IPlayerBuildingBlock Members

        public void Build(Player player)
        {
            player.Caliber = _outlook.GenerateCaliber();
        }

        #endregion
    }
}