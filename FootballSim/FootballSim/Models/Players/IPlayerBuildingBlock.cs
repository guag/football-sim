using FootballSim.Models.Positions;

namespace FootballSim.Models.Players
{
    public interface IPlayerBuildingBlock
    {
        void Build(Player player, IPosition position = null);
    }
}