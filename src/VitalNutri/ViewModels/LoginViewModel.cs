using System.ComponentModel.DataAnnotations;

namespace VitalNutri.ViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o email")]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }

        public string ReturnUrl { get; set; }
    }
}
