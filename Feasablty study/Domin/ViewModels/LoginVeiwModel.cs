using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Domin.ViewModels
{
    public class LoginViewModel
    {
        
            [Required]
            [EmailAddress]
            [Display(Name ="الايميل")]
            public string Email { get; set; }
            [Required]
            [DataType(DataType.Password)]
            [Display(Name ="Password")]
            public string Password { get; set; }
            [Display(Name = "Remember me?")]
            public bool RememberMe { get; set; }
        

    }
}
