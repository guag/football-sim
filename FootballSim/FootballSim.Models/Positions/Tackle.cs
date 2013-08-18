namespace FootballSim.Models.Positions
{
    public class Tackle : OffensiveLineman
    {
        public override PositionType Type
        {
            get { return PositionType.Tackle; }
        }
    }
}