namespace FootballSim.Models.Positions
{
    public struct Quarterback : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.Quarterback; }
        }

        public string Name
        {
            get { return "Quarterback"; }
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
            get { return 69; }
        }

        public int MaxHeight
        {
            get { return 78; }
        }

        #endregion
    }
}