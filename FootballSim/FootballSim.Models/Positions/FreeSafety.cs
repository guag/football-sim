namespace FootballSim.Models.Positions
{
    public class FreeSafety : DefensiveBack
    {
        public override PositionType Type
        {
            get { return PositionType.FreeSafety; }
        }

        public override string Name
        {
            get { return "Free Safety"; }
        }
    }
}