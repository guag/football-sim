namespace FootballSim.Models.Ratings
{
    public struct BlueChipCaliber : IPlayerCaliber
    {
        #region IPlayerCaliber Members

        public int MinValue
        {
            get { return 80; }
        }

        public int MaxValue
        {
            get { return 100; }
        }

        public override string ToString()
        {
            return "Blue Chip";
        }

        #endregion
    }
}