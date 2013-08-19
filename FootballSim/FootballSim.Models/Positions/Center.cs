namespace FootballSim.Models.Positions
{
    public class Center : OffensiveLineman
    {
        public override PositionType Type
        {
            get { return PositionType.Center; }
        }

        public override string ShortName
        {
            get { return "C"; }
        }
    }
}