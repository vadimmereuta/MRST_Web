using System;
using System.Linq;
using System.Web.Mvc;
using eUseControl.web.Models;
using eUseControl.Domain;
using eUseControl.Domain.Entities;
using eUseControl.Domain.Entities.Models;


namespace eUseControl.web.Controllers
{
    public class MealsController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            var username = Session["Username"].ToString();
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return RedirectToAction("Index", "Login");

            var meals = db.Meals
                .Where(m => m.UserId == user.Id)
                .OrderByDescending(m => m.Date)
                .ToList();

            return View(meals);
        }

        [HttpGet]
        public ActionResult Add()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            return View(new MealViewModel { Date = DateTime.Now });
        }

        [HttpPost]
        public ActionResult Add(MealViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var username = Session["Username"].ToString();
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return RedirectToAction("Index", "Login");

            var meal = new Meal
            {
                Name = model.Name,
                Date = model.Date,
                UserId = user.Id
            };

            db.Meals.Add(meal);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            var username = Session["Username"].ToString();
            var user = db.Users.FirstOrDefault(u => u.Username == username);
            if (user == null) return RedirectToAction("Index", "Login");

            var meal = db.Meals.FirstOrDefault(m => m.Id == id && m.UserId == user.Id);
            if (meal != null)
            {
                db.Meals.Remove(meal);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }

    }
}
