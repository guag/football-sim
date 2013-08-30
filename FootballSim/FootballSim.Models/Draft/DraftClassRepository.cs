using System.Linq;

namespace FootballSim.Models.Draft
{
    public interface IDraftClassRepository
    {
        void AddDraft(DraftClass draft);
        DraftClass GetDraft(int id);
    }

    public class DraftClassRepository : IDraftClassRepository
    {
        private readonly IFootballSimContext _context;

        public DraftClassRepository(IFootballSimContext context)
        {
            _context = context;
        }

        #region IDraftClassRepository Members

        /// <summary>
        ///   TODO: test this
        /// </summary>
        public void AddDraft(DraftClass draft)
        {
            _context.DraftClasses.Add(draft);
            _context.SaveChanges();
        }

        /// <summary>
        ///   TODO: test this
        /// </summary>
        public DraftClass GetDraft(int id)
        {
            DraftClass draft = _context.DraftClasses.FirstOrDefault(d => d.Id == id);
            return draft;
        }

        #endregion
    }
}