using Feasablty_study.Domin.Interfaces;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Market_study 
    {
        [ForeignKey("Feasibility_study")]
        [Key]
        public int FeasibilityStudyId { get; set; }
        public string AvailbleOpportunity { get; set; }
        public string StrengthPoints { get; set; }
        public string MarketGap { get; set; }
        public string TargetMarket { get; set; }
        public string ProjectLocationOnTheMap { get; set; }
        public string PointsOfEwakness { get; set; }
        public string Threats { get; set; }

        public double TotalExpected_revenue { get; set; }
        public double TotalMarketing_Activity { get; set; }
        public virtual Feasibility_study Feasibility_study { get; set; }


    }
}
