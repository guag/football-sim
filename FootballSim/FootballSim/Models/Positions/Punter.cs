namespace FootballSim.Models.Positions
{
    public struct Punter : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.Punter; }
        }

        public string Name
        {
            get { return "Punter"; }
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