using Feasablty_study.Domin.Interfaces;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Feasibility_study : IEntityBase
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "ادخل اسم المشروع "), MaxLength(150, ErrorMessage = "اسم المشروع طويل للغاية")]
        public string ProjectName { get; set; }
        public string Description { get; set; }
        public string ProjectLocation { get; set; }

        public string ProjectType { get; set; }

        public string ProjectLogo { get; set; }

        public DateTime DateTime { get; set; }


        public string ContactNumber { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public User user { get; set; }
        public Preliminary_study Preliminary_study { get; set; }
        public Market_study market_Study { get; set; }
        public Technical_Study technical_Study { get; set; }



    }
}
