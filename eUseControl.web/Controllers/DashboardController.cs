using System.Web.Mvc;

namespace eUseControl.web.Controllers
{
    public class DashboardController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            ViewBag.Username = Session["Username"];
            return View();
        }
    }
}
