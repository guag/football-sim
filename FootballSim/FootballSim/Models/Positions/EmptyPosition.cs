namespace FootballSim.Models.Positions
{
    public class EmptyPosition : Position
    {
        public override PositionType Type
        {
            get { return PositionType.None; }
        }

        public override string Name
        {
            get { return "None"; }
        }

        public override Side Side
        {
            get { return Side.None; }
        }

        public override int MinWeight
        {
            get { return 0; }
        }

        public override int MaxWeight
        {
            get { return 0; }
        }

        public override int MinHeight
        {
            get { return 0; }
        }

        public override int MaxHeight
        {
            get { return 0; }
        }
    }
}