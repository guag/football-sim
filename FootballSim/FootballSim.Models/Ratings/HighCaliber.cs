namespace FootballSim.Models.Ratings
{
    public class HighCaliber : IPlayerCaliber
    {
        #region IPlayerCaliber Members

        public int MinValue
        {
            get { return 70; }
        }

        public int MaxValue
        {
            get { return 95; }
        }

        public override string ToString()
        {
            return "High";
        }

        #endregion
    }
}