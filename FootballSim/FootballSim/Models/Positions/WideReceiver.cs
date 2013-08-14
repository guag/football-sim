namespace FootballSim.Models.Positions
{
    public struct WideReceiver : IPosition
    {
        #region IPosition Members

        public PositionType Type
        {
            get { return PositionType.WideReceiver; }
        }

        public string Name
        {
            get { return "Wide Receiver"; }
        }

        public Side Side
        {
            get { return Side.Offense; }
        }

        public int MinWeight
        {
            get { return 170; }
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
            get { return 80; }
        }

        #endregion
    }
}