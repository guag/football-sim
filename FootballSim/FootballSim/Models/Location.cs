namespace FootballSim.Models
{
    public interface ILocation
    {
        string City { get; set; }
        string State { get; set; }
    }

    public struct Location : ILocation
    {
        public Location(string city, string state)
            : this()
        {
            City = city;
            State = state;
        }

        public string City { get; set; }
        public string State { get; set; }
    }
}