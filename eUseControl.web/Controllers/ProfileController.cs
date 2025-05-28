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

        public ActionResult Edit()
        {
            string username = Session["Username"] as string;
            var user = db.Users.FirstOrDefault(u => u.Username == username);

            if (user == null) return HttpNotFound();

            var model = new EditProfileViewModel
            {
                Email = user.Email,
                Username = user.Username
            };

            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditProfileViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            string username = Session["Username"] as string;
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return HttpNotFound();

            user.Email = model.Email;
            user.Username = model.Username;

            if (!string.IsNullOrWhiteSpace(model.NewPassword))
                user.Password = model.NewPassword; // pentru securitate, hash recomandat

            db.SaveChanges();
            ViewBag.Message = "Datele au fost actualizate cu succes!";
            return View(model);
        }

    }
}
