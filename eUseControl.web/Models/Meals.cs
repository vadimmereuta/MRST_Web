using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.web.Models
{
    public class Meal
    {
        public int Id { get; set; }
        public string Name { get; set; } // ex: Mic Dejun
        public DateTime Date { get; set; }
        public List<FoodItem> Items { get; set; } = new List<FoodItem>();
    }

}