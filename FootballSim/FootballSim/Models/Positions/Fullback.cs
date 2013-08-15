namespace FootballSim.Models.Positions
{
    public class Fullback : Runningback
    {
        public override PositionType Type
        {
            get { return PositionType.Fullback; }
        }
    }
}