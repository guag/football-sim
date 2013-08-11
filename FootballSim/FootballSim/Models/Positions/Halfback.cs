namespace FootballSim.Models.Positions
{
    public struct Halfback : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.Halfback; }
        }

        public string Name
        {
            get { return "Halfback"; }
        }

        public Side Side
        {
            get { return Side.Offense; }
        }

        public int MinWeight
        {
            get { return 175; }
        }

        public int MaxWeight
        {
            get { return 265; }
        }

        public int MinHeight
        {
            get { return 65; }
        }

        public int MaxHeight
        {
            get { return 76; }
        }

        #endregion
    }
}