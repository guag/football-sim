using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;

namespace FootballSim.Models.Players
{
    public class Player
    {
        private readonly ISet<Rating> _ratings =
            new HashSet<Rating>();

        [Required]
        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public virtual Position Position { get; set; }

        [Required]
        public int JerseyNumber { get; set; }

        public virtual ITeam Team { get; set; }

        [Required]
        public Location Hometown { get; set; }

        [Required]
        public string College { get; set; }

        [Required]
        public Measurables Measurables { get; set; }

        [Required]
        public virtual IPlayerCaliber Caliber { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        public virtual ISet<Rating> Ratings
        {
            get { return _ratings; }
        }

        public string BirthDateForDisplay
        {
            get { return BirthDate.ToShortDateString(); }
        }

        public string FullName
        {
            get { return string.Format("{0}, {1}", LastName, FirstName); }
        }

        /// <summary>
        /// TODO: very crude, come up with something more sophisticated.
        /// </summary>
        public int CurrentOverallRating
        {
            get { return (int) Ratings.Average(r => r.CurrentValue); }
        }

        public int ProjectedOverallRating
        {
            get { return (int) Ratings.Average(r => r.ProjectedValue); }
        }
    }
}