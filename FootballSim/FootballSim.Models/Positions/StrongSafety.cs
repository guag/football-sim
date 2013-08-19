namespace FootballSim.Models.Positions
{
    public class StrongSafety : DefensiveBack
    {
        public override PositionType Type
        {
            get { return PositionType.StrongSafety; }
        }

        public override string Name
        {
            get { return "Strong Safety"; }
        }

        public override string ShortName
        {
            get { return "SS"; }
        }
    }
}