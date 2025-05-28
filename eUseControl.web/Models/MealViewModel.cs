using System;
using System.ComponentModel.DataAnnotations;

namespace eUseControl.web.Models
{
    public class MealViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
