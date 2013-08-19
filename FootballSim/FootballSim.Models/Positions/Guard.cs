namespace FootballSim.Models.Positions
{
    public class Guard : OffensiveLineman
    {
        public override PositionType Type
        {
            get { return PositionType.Guard; }
        }

        public override string ShortName
        {
            get { return "G"; }
        }
    }
}