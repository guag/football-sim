namespace FootballSim.Models.Positions
{
    public struct Cornerback : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.Cornerback; }
        }

        public string Name
        {
            get { return "Cornerback"; }
        }

        public Side Side
        {
            get { return Side.Defense; }
        }

        public int MinWeight
        {
            get { return 175; }
        }

        public int MaxWeight
        {
            get { return 220; }
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