namespace FootballSim.Models.Positions
{
    public class WideReceiver : PassCatcher
    {
        public override PositionType Type
        {
            get { return PositionType.WideReceiver; }
        }

        public override string Name
        {
            get { return "Wide Receiver"; }
        }

        public override int MinWeight
        {
            get { return 170; }
        }

        public override int MaxWeight
        {
            get { return 250; }
        }

        public override int MinHeight
        {
            get { return 69; }
        }

        public override int MaxHeight
        {
            get { return 78; }
        }
    }
}