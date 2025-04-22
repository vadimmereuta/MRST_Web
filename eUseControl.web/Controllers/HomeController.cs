using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using eUseControl.web.Models;

namespace eUseControl.web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var meal1 = new Meal
            {
                Name = "Mic Dejun",
                Date = DateTime.Now,
                Items = new List<FoodItem>
                {
                    new FoodItem { Name = "Ou fiert", Calories = 70 },
                    new FoodItem { Name = "Paine prajita", Calories = 120 },
                    new FoodItem { Name = "Paine", Calories = 100 }

                }
            };

            var meal2 = new Meal
            {
                Name = "Mare Dejun",
                Date = DateTime.Now,
                Items = new List<FoodItem>
                {
                    new FoodItem { Name = "Ou fiert", Calories = 70 },
                    new FoodItem { Name = "Paine prajita", Calories = 120 },
                    new FoodItem { Name = "Paine", Calories = 100 }

                }
            };

            var model = new UserMealViewModel
            {
                Username = "Vadim",
                Meals = new List<Meal> { meal1, meal2 }
            };

            return View(model);
        }

    }
}