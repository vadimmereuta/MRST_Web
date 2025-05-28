using System.Linq;
using System.Web.Mvc;
using eUseControl.Domain;
using eUseControl.Domain.Entities.Models;
using eUseControl.web.Models;

namespace eUseControl.web.Controllers
{
    public class FoodController : Controller
    {
        private readonly AppDbContext db = new AppDbContext();

        public ActionResult Index()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            var foods = db.FoodItems.ToList();
            return View(foods);
        }

        [HttpGet]
        public ActionResult Add()
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            return View(new FoodItemViewModel());
        }

        [HttpPost]
        public ActionResult Add(FoodItemViewModel model)
        {
            if (!ModelState.IsValid) return View(model);

            var food = new FoodItem
            {
                Name = model.Name,
                Calories = model.Calories,
                Protein = model.Protein,
                Carbs = model.Carbs,
                Fat = model.Fat
            };

            db.FoodItems.Add(food);
            db.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpPost]
        public ActionResult Delete(int id)
        {
            if (Session["Username"] == null)
                return RedirectToAction("Index", "Login");

            var food = db.FoodItems.FirstOrDefault(f => f.Id == id);
            if (food != null)
            {
                db.FoodItems.Remove(food);
                db.SaveChanges();
            }

            return RedirectToAction("Index");
        }


    }
}
