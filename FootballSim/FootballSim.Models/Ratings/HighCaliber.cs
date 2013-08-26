namespace FootballSim.Models.Ratings
{
    public class HighCaliber : PlayerCaliber
    {
        #region IPlayerCaliber Members

        public override int MinValue
        {
            get { return 70; }
        }

        public override int MaxValue
        {
            get { return 95; }
        }

        public override string Name
        {
            get { return "High"; }
        }

        #endregion
    }
}