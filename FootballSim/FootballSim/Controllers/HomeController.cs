using System;
using System.Web.Mvc;
using FootballSim.Models;

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
            return RedirectToAction("DraftClass");
        }

        public ActionResult DraftClass(int year = 2013, int numPlayers = 1000)
        {

            return View(_draftFactory.Create(new DateTime(year, 1, 1), numPlayers));
        }
    }
}
