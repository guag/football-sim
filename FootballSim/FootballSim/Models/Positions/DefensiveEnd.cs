namespace FootballSim.Models.Positions
{
    public struct DefensiveEnd : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.DefensiveEnd; }
        }

        public string Name
        {
            get { return "Defensive End"; }
        }

        public Side Side
        {
            get { return Side.Defense; }
        }

        public int MinWeight
        {
            get { return 260; }
        }

        public int MaxWeight
        {
            get { return 330; }
        }

        public int MinHeight
        {
            get { return 70; }
        }

        public int MaxHeight
        {
            get { return 84; }
        }

        #endregion
    }
}