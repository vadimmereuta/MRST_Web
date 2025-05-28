using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.web.Models
{
    public class MealDisplay
    {
        public int Id { get; set; }
        public string Name { get; set; } // ex: Mic Dejun
        public DateTime Date { get; set; }
        public List<FoodItemViewModel> Items { get; set; } = new List<FoodItemViewModel>();
    }

}