using System.Linq;
using System.Web.Mvc;
using eUseControl.Domain;
using eUseControl.web.Models;

namespace eUseControl.web.Controllers
{
    public class ProfileController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            string username = Session["Username"].ToString();
            var user = db.Users.FirstOrDefault(u => u.Username == username);

            if (user == null) return HttpNotFound();

            return View(user);
        }
    }
}
