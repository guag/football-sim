namespace FootballSim.Models.Positions
{
    public struct InsideLinebacker : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.InsideLinebacker; }
        }

        public string Name
        {
            get { return "Inside Linebacker"; }
        }

        public Side Side
        {
            get { return Side.Defense; }
        }

        public int MinWeight
        {
            get { return 240; }
        }

        public int MaxWeight
        {
            get { return 280; }
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