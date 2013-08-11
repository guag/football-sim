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
            get { return 155; }
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
            get { return 82; }
        }

        #endregion
    }
}