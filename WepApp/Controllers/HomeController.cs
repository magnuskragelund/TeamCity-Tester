using System.Web.Mvc;

namespace WepApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Hey, Dude.";
            return View();
        }

    }
}
