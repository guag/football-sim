namespace FootballSim.Models.Positions
{
    public class InsideLinebacker : Linebacker
    {
        public override PositionType Type
        {
            get { return PositionType.InsideLinebacker; }
        }

        public override string Name
        {
            get { return "Inside Linebacker"; }
        }
    }
}