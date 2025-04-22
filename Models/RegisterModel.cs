using System.ComponentModel.DataAnnotations;

namespace TaskManager.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage = "Name is required")]
        [StringLength(50, MinimumLength = 1, ErrorMessage = "Name cannot be longer than 50 characters")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid email address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Password is required")]
        [MinLength(6, ErrorMessage = "Password must be at least 6 characters")]
        public string Password { get; set; }
    }



}
