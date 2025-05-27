using eUseControl.Domain.Entities.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eUseControl.Domain.Entities
{
    public class MealItem
    {
        [Key]
        public int Id { get; set; }

        public int MealId { get; set; }

        [ForeignKey("MealId")]
        public virtual Meal Meal { get; set; }

        public int FoodItemId { get; set; }

        [ForeignKey("FoodItemId")]
        public virtual FoodItem FoodItem { get; set; }

        public float Quantity { get; set; } // ex: 100g sau 2 porții
    }
}
