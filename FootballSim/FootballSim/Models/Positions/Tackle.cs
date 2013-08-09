namespace FootballSim.Models.Positions
{
    public class Tackle : IPosition
    {
        public PositionType Type
        {
            get { return PositionType.Tackle; }
        }

        public string Name
        {
            get { return "Tackle"; }
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