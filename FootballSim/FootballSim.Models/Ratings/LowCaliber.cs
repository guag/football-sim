namespace FootballSim.Models.Ratings
{
    public class LowCaliber : IPlayerCaliber
    {
        #region IPlayerCaliber Members

        public int MinValue
        {
            get { return 50; }
        }

        public int MaxValue
        {
            get { return 75; }
        }

        public override string ToString()
        {
            return "Low";
        }

        #endregion
    }
}