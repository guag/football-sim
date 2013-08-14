namespace FootballSim.Models.Positions
{
    public struct DefensiveTackle : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.DefensiveTackle; }
        }

        public string Name
        {
            get { return "Defensive Tackle"; }
        }

        public Side Side
        {
            get { return Side.Defense; }
        }

        public int MinWeight
        {
            get { return 275; }
        }

        public int MaxWeight
        {
            get { return 350; }
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