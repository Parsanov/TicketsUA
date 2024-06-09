using System.ComponentModel.DataAnnotations;

namespace TicketsUA.ViewModel
{
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email address is required")]
        public string EmailAdress { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password is required")]
        public string Password { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password is required")]
        public string ConfirmPassword { get; set; }
    }
}
