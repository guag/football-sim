namespace FootballSim.Models.Positions
{
    public class Punter : Kicker
    {
        public override PositionType Type
        {
            get { return PositionType.Punter; }
        }

        public override string ShortName
        {
            get { return "P"; }
        }
    }
}