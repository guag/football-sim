namespace FootballSim.Models.Ratings
{
    public class LowCaliber : PlayerCaliber
    {
        #region IPlayerCaliber Members

        public override int MinValue
        {
            get { return 50; }
        }

        public override int MaxValue
        {
            get { return 75; }
        }

        public override string Name
        {
            get { return "Low"; }
        }

        #endregion
    }
}