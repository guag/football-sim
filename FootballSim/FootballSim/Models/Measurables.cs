namespace FootballSim.Models
{
    public struct Measurables
    {
        public int Height { get; set; }
        public int Weight { get; set; }

        public string HeightForDisplay
        {
            get { return string.Format("{0}'{1}\"", Height/12, Height%12); }
        }
    }
}