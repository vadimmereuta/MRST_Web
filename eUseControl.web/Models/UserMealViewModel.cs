using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eUseControl.web.Models
{
    public class UserMealViewModel
    {
        public string Username { get; set; }
        public List<MealDisplay> Meals { get; set; }
    }
}