namespace FootballSim.Models.Positions
{
    public class TightEnd : PassCatcher
    {
        public override PositionType Type
        {
            get { return PositionType.TightEnd; }
        }

        public override string Name
        {
            get { return "Tight End"; }
        }

        public override int MinWeight
        {
            get { return 220; }
        }

        public override int MaxWeight
        {
            get { return 280; }
        }

        public override int MinHeight
        {
            get { return 70; }
        }

        public override int MaxHeight
        {
            get { return 84; }
        }
    }
}