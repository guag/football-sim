using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public interface ICollegeBuilder : IPlayerBuildingBlock
    {
    }

    public class CollegeBuilder : ICollegeBuilder
    {
        private readonly IRandomCollegeRetriever _colleges;

        public CollegeBuilder(IRandomCollegeRetriever colleges)
        {
            _colleges = colleges;
        }

        #region ICollegeBuilder Members

        public void Build(Player player, IPosition position = null)
        {
            player.College = _colleges.GetRandomCollege();
        }

        #endregion
    }
}