using System.ComponentModel.DataAnnotations;

namespace GigHub.WebApplication.ViewModels
{

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
