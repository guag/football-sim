using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface INameBuilder : IPlayerBuildingBlock
    {
    }

    public class NameBuilder : INameBuilder
    {
        private readonly INameRetriever _names;

        public NameBuilder(INameRetriever names)
        {
            _names = names;
        }

        public void Build(Player player, IPosition position = null)
        {
            player.FirstName = _names.GetRandomFirstName();
            player.LastName = _names.GetRandomLastName();
        }
    }
}