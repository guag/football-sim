namespace FootballSim.Models.Positions
{
    public struct OutsideLinebacker : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.OutsideLinebacker; }
        }

        public string Name
        {
            get { return "Outside Linebacker"; }
        }

        public Side Side
        {
            get { return Side.Defense; }
        }

        public int MinWeight
        {
            get { return 225; }
        }

        public int MaxWeight
        {
            get { return 260; }
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