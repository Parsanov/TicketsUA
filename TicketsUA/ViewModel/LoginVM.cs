using System.ComponentModel.DataAnnotations;

namespace TicketsUA.ViewModel
{
    public class LoginVM
    {
        [Display(Name = "Email user")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

    }
}
