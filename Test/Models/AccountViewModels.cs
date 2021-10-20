using System.ComponentModel.DataAnnotations;

namespace Test.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string UserName { get; set; }
    }

    public class ManageUserViewModel
    {
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Obecne Hasło")]
        public string OldPassword { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} musi mieć co najmniej {2} znaki.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Nowe Hasło")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwierdź nowe hasło")]
        [Compare("NewPassword", ErrorMessage = "Podane hasło i jego potwierdzenie nie pasują do siebie.")]
        public string ConfirmPassword { get; set; }
    }

    public class LoginViewModel
    {
        [Required]
        [Display(Name = "Nazwa")]
        public string UserName { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [Display(Name = "Pamiętasz mnie?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {

        [Required]
        [Display(Name = "Nazwa")]
        public string UserName { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "{0} musi mieć co najmniej {2} znaki.", MinimumLength = 6)]
        [DataType(DataType.Password)]
        [Display(Name = "Hasło")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Potwiedź Hasło")]
        [Compare("Password", ErrorMessage = "Podane hasło i jego potwierdzenie nie pasują do siebie.")]
        public string ConfirmPassword { get; set; }

        [Required]
        [Display(Name = "Imię")]
        public string Imie { get; set; }

        [Required]
        [Display(Name = "Nazwisko")]
        public string Nazwisko { get; set; }

        [Required]
        [Display(Name = "Data Urodzenia")]
        public string DataUrodzenia { get; set; }
    }
}
