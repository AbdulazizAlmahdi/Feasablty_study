using Feasablty_study.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Domin.ViewModels
{
    public class UserPrivilegesModelView
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "ادخل الاسم ")]
        public string Name { get; set; }

        public bool Status { get; set; } = false;

        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "يرجى ادخال الايميل"), RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "صيغة الايميل غير صالحة")]
        public string Email { get; set; }
        [Required(ErrorMessage = "ادخل اسم المسنخدم")]
        [Display(Name = "User Name")]
        // [Remote(action: "IsUserNameExist", controller:"Users",ErrorMessage ="اسم المستخدم موجود مسبقا")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "يرجى ادخال كلمة المرور")]
        public string Password { get; set; }
        [Required(ErrorMessage = "يرجى اعادة ادخال كلمة المرور"), Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "CreationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public virtual ICollection<Support_Messages> messages { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
