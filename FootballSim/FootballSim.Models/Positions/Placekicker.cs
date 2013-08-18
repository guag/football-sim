namespace FootballSim.Models.Positions
{
    public class Placekicker : Kicker
    {
        public override PositionType Type
        {
            get { return PositionType.Kicker; }
        }
    }
}