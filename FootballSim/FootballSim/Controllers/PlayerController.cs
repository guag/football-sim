using System.Web.Mvc;

namespace FootballSim.Controllers
{
    public class PlayerController : Controller
    {
        //
        // GET: /Player/

        public ActionResult Index(int id = 0)
        {
            // TODO: get Player from DB, send to View.
            return View();
        }

    }
}
