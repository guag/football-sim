namespace FootballSim.Models.Ratings
{
    public class AverageCaliber : PlayerCaliber
    {
        #region IPlayerCaliber Members

        public override int MinValue
        {
            get { return 60; }
        }

        public override int MaxValue
        {
            get { return 85; }
        }

        public override string Name
        {
            get { return "Average"; }
        }

        #endregion
    }
}