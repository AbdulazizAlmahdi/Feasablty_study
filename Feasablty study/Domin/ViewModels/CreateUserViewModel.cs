﻿using Feasablty_study.Domin.Entites;
using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Domin.ViewModels
{
    public class CreateUserViewModel
    {

       
        [Required(ErrorMessage = "ادخل الاسم ")]
        public string Name { get; set; }
        [Required(ErrorMessage = "ادخل اسم المستخدم "), RegularExpression(@"^(?=[a-zA-Z0-9._]{5,20}$)(?!.*[_.]{2})[^_.].*[^_.]$", ErrorMessage = " لا يجب ان تحتوي على مسافات و يجب ان يكون اكثر من 5 حروف")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "ادخل رقم الهاتف"), MaxLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اكثر من تسعة ارقام "), MinLength(9, ErrorMessage = "يجب ان لا يكون رقم الهاتف اقل من تسعة ارقام")]
        public string PhoneNumber { get; set; }
        [Required(ErrorMessage = "يرجى ادخال الايميل"), RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "صيغة الايميل غير صالحة")]
        [Display(Name = "الايميل")]
        public string Email { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى ادخال كلمة المرور"), RegularExpression(@"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$", ErrorMessage = "صيغة يجب ان تكون كلمة السر ارقام و حروف و رموز")]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "يرجى اعادة ادخال كلمة المرور"), Compare("Password", ErrorMessage = "كلمة المرور غير متطابقة")]
        public string PasswordConfirm { get; set; }
        [Display(Name ="حالة المستخدم (مفعل / معطل )")]
        public bool Status { get; set; }
        [Display(Name="نوع المستخدم")]
        public int UserRoles { get; set; }
        public int RegionId { get; set; }
        public object RegisterViewModelId { get; internal set; }
        public string RegisterViewId { get; internal set; }
        public string CreateUserViewModelId { get; internal set; }
        public string CreateUserId { get; internal set; }
    }
}
