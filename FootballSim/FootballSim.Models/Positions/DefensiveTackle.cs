namespace FootballSim.Models.Positions
{
    public class DefensiveTackle : DefensiveLineman
    {
        public override PositionType Type
        {
            get { return PositionType.DefensiveTackle; }
        }

        public override string Name
        {
            get { return "Defensive Tackle"; }
        }

        public override string ShortName
        {
            get { return "DT"; }
        }
    }
}