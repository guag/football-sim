using System.Data.Entity;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.Positions;
using FootballSim.Models.Ratings;

namespace FootballSim.Models
{
    public interface IFootballSimContext
    {
        IDbSet<Player> Players { get; set; }
        IDbSet<DraftClass> DraftClasses { get; set; }
        IDbSet<Position> Positions { get; set; }
        IDbSet<Rating> Ratings { get; set; }
        int SaveChanges();
    }

    public class FootballSimContext : DbContext, IFootballSimContext
    {
        #region IFootballSimContext Members

        public IDbSet<Player> Players { get; set; }
        public IDbSet<DraftClass> DraftClasses { get; set; }
        public IDbSet<Position> Positions { get; set; }
        public IDbSet<Rating> Ratings { get; set; }

        #endregion
    }
}