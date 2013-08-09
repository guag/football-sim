namespace FootballSim.Models.Positions
{
    public class Guard : IPosition
    {
        public PositionType Type
        {
            get { return PositionType.Guard; }
        }

        public string Name
        {
            get { return "Guard"; }
        }

        public Side Side
        {
            get { return Side.Offense; }
        }

        public int MinWeight
        {
            get { return 260; }
        }

        public int MaxWeight
        {
            get { return 400; }
        }

        public int MinHeight
        {
            get { return 70; }
        }

        public int MaxHeight
        {
            get { return 86; }
        }
    }
}