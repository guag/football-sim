using FootballSim.Models.Positions;

namespace FootballSim.Models
{
    public class Player
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public IPosition Position { get; set; }
        public ITeam Team { get; set; }
        public ILocation Hometown { get; set; }
        public string College { get; set; }
    }
}