using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using FootballSim.Models.Players;

namespace FootballSim.Models.Draft
{
    public class DraftClass
    {
        private IList<Player> _players = new List<Player>();

        [Key]
        public int Id { get; set; }

        [Required]
        public int Year { get; set; }

        public virtual IList<Player> Players
        {
            get { return _players; }
            set { _players = value; }
        }
    }
}