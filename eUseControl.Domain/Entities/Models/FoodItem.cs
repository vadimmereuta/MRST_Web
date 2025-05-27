using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eUseControl.Domain.Entities.Models
{
    public class FoodItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int Calories { get; set; }
        public float Protein { get; set; }
        public float Carbs { get; set; }
        public float Fat { get; set; }
    }
}
