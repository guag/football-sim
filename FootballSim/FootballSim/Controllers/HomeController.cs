using System.Web.Mvc;
using FootballSim.Models;
using System.Linq;
using FootballSim.Models.ViewModels;

namespace FootballSim.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDraftClassFactory _draftFactory;

        public HomeController(IDraftClassFactory draftFactory)
        {
            _draftFactory = draftFactory;
        }

        public ActionResult Index()
        {
            // TODO: temporary
            return RedirectToAction("DraftClass");
        }

        public ActionResult DraftClass(int year = 2013, int numPlayers = 500)
        {
            //  TODO: temporary. move to separate controller.
            var draft = _draftFactory.Create(year, numPlayers);

            var sortedPlayers = draft.Players
                .OrderBy(p => p.Position.Type)
                .ThenByDescending(p => p.CurrentOverallRating)
                .ThenBy(p => p.LastName);

            return View(new DraftClassViewModel
            {
                Players = sortedPlayers,
                Year = year
            });
        }
    }
}
