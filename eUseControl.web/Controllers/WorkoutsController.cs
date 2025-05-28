using System.Linq;
using System.Web.Mvc;
using eUseControl.Domain;
using eUseControl.Domain.Entities;

namespace eUseControl.web.Controllers
{
    public class WorkoutsController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            var username = Session["Username"].ToString();
            var user = db.Users.FirstOrDefault(u => u.Username == username);

            var workouts = db.Workouts.Where(w => w.UserId == user.Id).ToList();
            return View(workouts);
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Workout workout)
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            var username = Session["Username"].ToString();
            var user = db.Users.FirstOrDefault(u => u.Username == username);

            workout.UserId = user.Id;
            db.Workouts.Add(workout);
            db.SaveChanges();

            return RedirectToAction("Index");
        }


        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            var workout = db.Workouts.FirstOrDefault(w => w.Id == id);
            if (workout != null)
            {
                db.Workouts.Remove(workout);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
