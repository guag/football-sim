using FootballSim.Models.Positions;

namespace FootballSim.Models.Players
{
    public interface INameBuilder : IPlayerBuildingBlock
    {
    }

    public class NameBuilder : INameBuilder
    {
        private readonly INameCache _names;

        public NameBuilder(INameCache names)
        {
            _names = names;
        }

        #region INameBuilder Members

        public void Build(Player player, IPosition position = null)
        {
            player.FirstName = _names.GetRandomFirstName();
            player.LastName = _names.GetRandomLastName();
        }

        #endregion
    }
}