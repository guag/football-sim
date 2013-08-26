namespace FootballSim.Models.Ratings
{
    public class BlueChipCaliber : PlayerCaliber
    {
        public override int MinValue
        {
            get { return 80; }
        }

        public override int MaxValue
        {
            get { return 100; }
        }

        public override string Name
        {
            get { return "Blue Chip"; }
        }
    }
}