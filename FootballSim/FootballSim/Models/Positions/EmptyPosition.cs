namespace FootballSim.Models.Positions
{
    public class EmptyPosition : IPosition
    {
        public PositionType Type
        {
            get { return PositionType.None; }
        }

        public string Name
        {
            get { return "None"; }
        }
        public Side Side
        {
            get { return Side.None; }
        }
        public double MinWeight { get; set; }
        public double MaxWeight { get; set; }
        public double MinHeight { get; set; }
        public double MaxHeight { get; set; }
    }
}