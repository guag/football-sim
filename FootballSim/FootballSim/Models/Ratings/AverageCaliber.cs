namespace FootballSim.Models.Ratings
{
    public class AverageCaliber : IPlayerCaliber
    {
        #region IPlayerCaliber Members

        public int MinValue
        {
            get { return 60; }
        }

        public int MaxValue
        {
            get { return 85; }
        }

        public override string ToString()
        {
            return "Average";
        }

        #endregion
    }
}