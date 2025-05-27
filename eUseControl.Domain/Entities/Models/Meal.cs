using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace eUseControl.Domain.Entities.Models
{
    public class Meal
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; }

        public int UserId { get; set; }

        [ForeignKey("UserId")]
        public virtual User User { get; set; }

        public virtual ICollection<MealItem> MealItems { get; set; }
    }
}
