using System.Collections.Generic;
using System.Linq;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Players
{
    public class Player
    {
        private readonly IDictionary<RatingType, Rating> _ratings =
            new Dictionary<RatingType, Rating>();

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Position Position { get; set; }
        public int JerseyNumber { get; set; }
        public ITeam Team { get; set; }
        public Location Hometown { get; set; }
        public string College { get; set; }
        public Measurables Measurables { get; set; }

        public IDictionary<RatingType, Rating> Ratings
        {
            get { return _ratings; }
        }

        /// <summary>
        /// TODO: very crude, come up with something more sophisticated.
        /// </summary>
        public int CurrentOverallRating
        {
            get { return (int) Ratings.Values.Average(r => r.CurrentValue); }
        }

        public int ProjectedOverallRating
        {
            get { return (int) Ratings.Values.Average(r => r.ProjectedValue); }
        }
    }
}