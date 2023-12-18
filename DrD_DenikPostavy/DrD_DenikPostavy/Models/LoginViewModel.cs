namespace DrD_DenikPostavy.Models
{
    using System.ComponentModel.DataAnnotations;
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Vyplňte e-mailovou adresu.")]
        [EmailAddress(ErrorMessage ="Neplatná e-mailová adresa")]
        [Display(Name = "E-mail")]
        public string Email { get; set; } = "";

        [Required(ErrorMessage ="Vyplňte heslo")]
        [DataType(DataType.Password)]
        [Display(Name = "Heslo")]
        public string Password { get; set; } = "";

        [Display(Name ="Zapamatovat si mě.")]
        public bool RememberMe { get; set; }
    }
}
