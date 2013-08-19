namespace FootballSim.Models.Positions
{
    public class Halfback : Runningback
    {
        public override PositionType Type
        {
            get { return PositionType.Halfback; }
        }

        public override string ShortName
        {
            get { return "HB"; }
        }
    }
}