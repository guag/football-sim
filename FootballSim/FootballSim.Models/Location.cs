namespace FootballSim.Models
{
    public struct Location
    {
        public string City { get; set; }
        public string State { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1}", City, State);
        }
    }
}