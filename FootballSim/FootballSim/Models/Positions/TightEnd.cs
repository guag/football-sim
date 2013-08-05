namespace FootballSim.Models.Positions
{
    public struct TightEnd : IPosition
    {
        public PositionType Type
        {
            get { return PositionType.TightEnd; }
        }

        public string Name
        {
            get { return "Tight End"; }
        }

        public Side Side
        {
            get { return Side.Offense; }
        }

        public double MinWeight
        {
            get { return 220; }
        }

        public double MaxWeight
        {
            get { return 280; }
        }

        public double MinHeight
        {
            get { return 68; }
        }

        public double MaxHeight
        {
            get { return 84; }
        }
    }
}