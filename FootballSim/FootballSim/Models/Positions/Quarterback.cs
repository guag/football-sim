namespace FootballSim.Models.Positions
{
    public struct Quarterback : IPosition
    {
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

        public double MinWeight
        {
            get { return 155; }
        }

        public double MaxWeight
        {
            get { return 265; }
        }

        public double MinHeight
        {
            get { return 65; }
        }

        public double MaxHeight
        {
            get { return 82; }
        }
    }
}