namespace FootballSim.Models.Positions
{
    public class DefensiveEnd : DefensiveLineman
    {
        public override PositionType Type
        {
            get { return PositionType.DefensiveEnd; }
        }

        public override string Name
        {
            get { return "Defensive End"; }
        }

        public override string ShortName
        {
            get { return "DE"; }
        }
    }
}