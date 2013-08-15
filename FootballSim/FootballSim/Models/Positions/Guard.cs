namespace FootballSim.Models.Positions
{
    public class Guard : OffensiveLineman
    {
        public override PositionType Type
        {
            get { return PositionType.Guard; }
        }
    }
}