﻿using Feasablty_study.Domin.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Support_Messages   :IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "يرجى ادخال عنوان الرسالة")]
        public string Title { get; set; }
        [Required(ErrorMessage = "يرجى ادخال محتوى الرسالة  ")]
        public string Content { get; set; } = "";
        [Required(ErrorMessage ="ادخل البريد الالكتروني الخاص بك"), RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Your Email is not valid.")]
        public string Email { get; set; }
        public DateTime Date { get; set; }= DateTime.Now;
        public string UserId { get; set; }
        public User User { get; set; }


    }
}
