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

        public void AddDraft(DraftClass draft)
        {
            _context.DraftClasses.Add(draft);
            _context.SaveChanges();
        }

        public DraftClass GetDraft(int id)
        {
            return _context.DraftClasses.FirstOrDefault(d => d.Id == id);
        }

        #endregion
    }
}