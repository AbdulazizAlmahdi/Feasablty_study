using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Feasibility_study
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



    }
}
