using System.ComponentModel.DataAnnotations;

namespace eUseControl.web.Models
{
    public class FoodItemViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Calories { get; set; }

        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
    }
}
