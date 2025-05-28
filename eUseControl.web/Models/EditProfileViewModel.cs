using System.ComponentModel.DataAnnotations;

namespace eUseControl.web.Models
{
    public class EditProfileViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 3)]
        [Display(Name = "Username")]
        public string Username { get; set; }

        [StringLength(50, MinimumLength = 6)]
        [Display(Name = "Parola nouă")]
        public string NewPassword { get; set; }
    }
}
