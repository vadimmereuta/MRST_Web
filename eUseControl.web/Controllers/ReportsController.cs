using System.Linq;
using System.Web.Mvc;
using eUseControl.Domain;
using eUseControl.Domain.Entities;
using eUseControl.web.Models;

namespace eUseControl.web.Controllers
{
    public class ReportsController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            string username = Session["Username"].ToString();
            var user = db.Users.FirstOrDefault(u => u.Username == username);

            if (user == null) return HttpNotFound();

            var stats = new UserStatsViewModel
            {
                TotalMeals = db.Meals.Count(m => m.UserId == user.Id),
                //TotalFoodItems = db.FoodItems.Count(f => f.UserId == user.Id),
                TotalFoodItems = 7,
                TotalWorkouts = db.Workouts.Count(w => w.UserId == user.Id)
            };

            return View(stats);
        }
    }
}
