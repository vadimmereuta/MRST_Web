using System;
using System.ComponentModel.DataAnnotations;

namespace eUseControl.Domain.Entities
{
    public class Workout
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int UserId { get; set; }

        [Required]
        public string Type { get; set; } // ex: Alergare, Forță, Înot

        public int DurationMinutes { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;
    }
}
