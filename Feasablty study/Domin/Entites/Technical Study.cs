using Feasablty_study.Domin.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Technical_Study 
    {

        [ForeignKey("Feasibility_study")]
        [Key]
        public int FeasibilityStudyId { get; set; }
        public virtual Feasibility_study feasibility_study { get; set; }
        


    }
}
