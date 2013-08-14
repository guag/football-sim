namespace FootballSim.Models.Positions
{
    public struct Center : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.Center; }
        }

        public string Name
        {
            get { return "Center"; }
        }

        public Side Side
        {
            get { return Side.Offense; }
        }

        public int MinWeight
        {
            get { return 250; }
        }

        public int MaxWeight
        {
            get { return 360; }
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