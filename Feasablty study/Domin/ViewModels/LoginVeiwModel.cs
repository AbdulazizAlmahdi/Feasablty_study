using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Domin.ViewModels
{
    public class LoginViewModel
    {
        
            [Required(ErrorMessage ="حق الايميل مطلوب")]
            [EmailAddress(ErrorMessage ="يرجى كتابة الايميل بشكل صحيح")]
            [Display(Name ="الايميل")]
            public string Email { get; set; }
            [Required(ErrorMessage ="ادخل كلمة المرور ")]
            [DataType(DataType.Password)]
            [Display(Name ="Password")]
            public string Password { get; set; }
            [Display(Name = "تذكرني")]
            public bool RememberMe { get; set; }
        

    }
}
