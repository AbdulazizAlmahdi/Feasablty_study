using Feasablty_study.Domin.Interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class User: IdentityUser
    {

        [Required(ErrorMessage ="ادخل الاسم ")]
        public string Name { get; set; }
        public bool Status { get; set; }        
        [DataType(DataType.Date)]
        [Display(Name = "CreationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        public virtual ICollection <Support_Messages> messages { get; set; }
        public virtual ICollection<Feasibility_study> Feasibility_Studies { get; set; }


    }
}
