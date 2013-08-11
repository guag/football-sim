namespace FootballSim.Models.Positions
{
    public struct TightEnd : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.TightEnd; }
        }

        public string Name
        {
            get { return "Tight End"; }
        }

        public Side Side
        {
            get { return Side.Offense; }
        }

        public int MinWeight
        {
            get { return 220; }
        }

        public int MaxWeight
        {
            get { return 280; }
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