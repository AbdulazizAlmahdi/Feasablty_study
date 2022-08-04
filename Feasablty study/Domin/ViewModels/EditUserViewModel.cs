using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Domin.ViewModels
{
    public class EditUserViewModel
    {

       
        [Required(ErrorMessage = "ادخل الاسم ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "يرجى ادخال الايميل"), RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "صيغة الايميل غير صالحة")]
        [Display(Name = "الايميل")]
        public string Email { get; set; }
        [Required(ErrorMessage = "ادخل اسم المسنخدم")]
        [Display(Name = "User Name")]
        // [Remote(action: "IsUserNameExist", controller:"Users",ErrorMessage ="اسم المستخدم موجود مسبقا")]
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى ادخال كلمة المرور")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى اعادة ادخال كلمة المرور"), Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }
        public bool Status { get; set; }




    }
}
