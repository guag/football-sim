namespace FootballSim.Models.Positions
{
    public class Cornerback : DefensiveBack
    {
        public override PositionType Type
        {
            get { return PositionType.Cornerback; }
        }

        public override string ShortName
        {
            get { return "CB"; }
        }
    }
}