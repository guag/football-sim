namespace FootballSim.Models.Players
{
    public interface ICollegeBuilder : IPlayerBuildingBlock
    {
    }

    public class CollegeBuilder : ICollegeBuilder
    {
        private readonly ICollegeCache _colleges;

        public CollegeBuilder(ICollegeCache colleges)
        {
            _colleges = colleges;
        }

        #region ICollegeBuilder Members

        public void Build(Player player)
        {
            player.College = _colleges.GetRandomCollege();
        }

        #endregion
    }
}