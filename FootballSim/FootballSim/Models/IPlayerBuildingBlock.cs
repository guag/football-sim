using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface IPlayerBuildingBlock
    {
        void Build(Player player, IPosition position = null);
    }
}
