using System.Linq;
using System.Web.Mvc;
using FootballSim.Models.Draft;
using FootballSim.Models.Players;
using FootballSim.Models.ViewModels;

namespace FootballSim.Controllers
{
    public class HomeController : Controller
    {
        private readonly IDraftClassBuilder _draftBuilder;

        public HomeController(IDraftClassBuilder draftBuilder)
        {
            _draftBuilder = draftBuilder;
        }

        public ActionResult Index()
        {
            // TODO: temporary
            return RedirectToAction("DraftClass");
        }

        public ActionResult DraftClass(int year = 2013, int numPlayers = 500)
        {
            //  TODO: temporary. move to separate controller.
            IDraftClass draft = _draftBuilder.Build(year, numPlayers);

            IOrderedEnumerable<Player> sortedPlayers = draft.Players
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