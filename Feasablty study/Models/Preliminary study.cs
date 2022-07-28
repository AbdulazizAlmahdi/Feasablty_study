using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Preliminary_study
    {
        public int Id { get; set; }

        public string ProjectObjectives { get; set; }

        public string VisionOfTheProject { get; set; }

        public string CteristicsOfTheProjectArea { get; set; }

        public string FactorsRepresentedOnIncreasedDemand { get; set; }

        public string FactorsRepresentedOnLowDemand { get; set; }
        [ForeignKey("Feasibility_study")]
        public int FeasibilityStudyId { get; set; }
        public Feasibility_study feasibility_study { get; set; }
        public ICollection<License> licenses { get; set; }

    }
}
