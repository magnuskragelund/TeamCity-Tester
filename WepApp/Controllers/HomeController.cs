using System.Web.Mvc;
using Common;

namespace WepApp.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewBag.Message = "Hey, ".AppendDude();
            return View();
        }

    }
}
