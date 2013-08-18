namespace FootballSim.Models.Positions
{
    public class OutsideLinebacker : Linebacker
    {
        public override PositionType Type
        {
            get { return PositionType.OutsideLinebacker; }
        }

        public override string Name
        {
            get { return "Outside Linebacker"; }
        }
    }
}