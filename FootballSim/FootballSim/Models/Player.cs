using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public class Player
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IPosition Position { get; set; }
        public ITeam Team { get; set; }
        public Location Hometown { get; set; }
        public string College { get; set; }
        public Measurables Measurables { get; set; }
    }
}