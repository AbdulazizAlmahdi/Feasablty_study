using Feasablty_study.Domin.Entites;
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

        public User()
        {
            Feasibility_Studies = new HashSet<Feasibility_study>();
        }

        [Required(ErrorMessage ="ادخل الاسم ")]
        public string Name { get; set; }
        public bool Status { get; set; }        
        [DataType(DataType.Date)]
        [Display(Name = "CreationDate")]
        public DateTime CreationDate { get; set; } = DateTime.Now;
        [ForeignKey("regions")]
        public virtual int RegionId { get; set; }
        public virtual Regions Region { get; set; }
        public int RoleId { get; set; }
        public virtual ICollection <Support_Messages> Messages { get; set; }
        public virtual ICollection<Feasibility_study> Feasibility_Studies { get; set; }


    }
}
