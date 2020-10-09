using System.ComponentModel.DataAnnotations;

namespace PartialView.Models
{
    public class Login
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public class Registration
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        [Display(Name = "Confirm Password")]
        public string ConfirmPassword { get; set; }
    }
}