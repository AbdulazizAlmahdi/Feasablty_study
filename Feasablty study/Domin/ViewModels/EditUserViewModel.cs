using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Domin.ViewModels
{
    public class EditUserViewModel
    {

       
        [Required(ErrorMessage = "ادخل الاسم ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        public string PhoneNumber { get; set; }
        // [Remote(action: "IsUserNameExist", controller:"Users",ErrorMessage ="اسم المستخدم موجود مسبقا")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى ادخال كلمة المرور")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى اعادة ادخال كلمة المرور"), Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }
        public bool Status { get; set; }
        [Display(Name = "نوع المستخدم")]
        public int userRoles { get; set; }




    }
}
