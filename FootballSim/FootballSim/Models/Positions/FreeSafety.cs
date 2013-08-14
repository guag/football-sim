namespace FootballSim.Models.Positions
{
    public struct FreeSafety : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.FreeSafety; }
        }

        public string Name
        {
            get { return "Free Safety"; }
        }

        public Side Side
        {
            get { return Side.Defense; }
        }

        public int MinWeight
        {
            get { return 180; }
        }

        public int MaxWeight
        {
            get { return 225; }
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