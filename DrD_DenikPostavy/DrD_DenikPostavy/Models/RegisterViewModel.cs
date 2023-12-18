using System.ComponentModel.DataAnnotations;

namespace DrD_DenikPostavy.Models
{
    public class RegisterViewModel
    {
        
            [Required(ErrorMessage = "Vyplňte emailovou adresu")]
            [EmailAddress(ErrorMessage = "Neplatná emailová adresa")]
            [Display(Name = "Email")]
            public string Email { get; set; } = "";

            [Required(ErrorMessage = "Vyplňte heslo")]
            [StringLength(100, ErrorMessage = "{0} musí mít délku alespoň {2} a nejvíc {1} znaků.", MinimumLength = 8)]
            [DataType(DataType.Password)]
            [Display(Name = "Heslo")]
            public string Password { get; set; } = "";

            [Required(ErrorMessage = "Vyplňte heslo")]
            [DataType(DataType.Password)]
            [Display(Name = "Potvrzení hesla")]
            [Compare(nameof(Password), ErrorMessage = "Zadaná hesla se musí shodovat.")]
            public string ConfirmPassword { get; set; } = "";
        
    }
}
