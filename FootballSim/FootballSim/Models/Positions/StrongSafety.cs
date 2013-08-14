namespace FootballSim.Models.Positions
{
    public struct StrongSafety : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.StrongSafety; }
        }

        public string Name
        {
            get { return "Strong Safety"; }
        }

        public Side Side
        {
            get { return Side.Defense; }
        }

        public int MinWeight
        {
            get { return 185; }
        }

        public int MaxWeight
        {
            get { return 230; }
        }

        public int MinHeight
        {
            get { return 69; }
        }

        public int MaxHeight
        {
            get { return 76; }
        }

        #endregion
    }
}