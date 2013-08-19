namespace FootballSim.Models.Positions
{
    public class Fullback : Runningback
    {
        public override PositionType Type
        {
            get { return PositionType.Fullback; }
        }

        public override string ShortName
        {
            get { return "FB"; }
        }
    }
}