using Feasablty_study.Domin.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Preliminary_study 
    {
        [ForeignKey("Feasibility_study")]
        [Key]
        public int FeasibilityStudyId { get; set; }
        public string VisionOfTheProject { get; set; }
        public string MessageOfTheProject { get; set; }

        public string ProjectObjectives { get; set; }

        public string CteristicsOfTheProjectArea { get; set; }

        public string FactorsRepresentedOnIncreasedDemand { get; set; }

        public string FactorsRepresentedOnLowDemand { get; set; }
        public Feasibility_study feasibility_study { get; set; }


    }
}
