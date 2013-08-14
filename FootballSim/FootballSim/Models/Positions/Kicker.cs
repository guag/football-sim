namespace FootballSim.Models.Positions
{
    public struct Kicker : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.Kicker; }
        }

        public string Name
        {
            get { return "Kicker"; }
        }

        public Side Side
        {
            get { return Side.SpecialTeams; }
        }

        public int MinWeight
        {
            get { return 160; }
        }

        public int MaxWeight
        {
            get { return 250; }
        }

        public int MinHeight
        {
            get { return 68; }
        }

        public int MaxHeight
        {
            get { return 76; }
        }

        #endregion
    }
}