using System.Collections;
using System.Collections.Generic;

namespace Feasablty_study.Models
{
    public class Market_study
    {
        public int Id { get; set; }
        public string AvailbleOpportunity { get; set; }
        public string CompetitiveAdavantages { get; set; }
        public string Logography { get; set; }
        public string WatermarkMarketd { get; set; }

        public string ProjectLocationOnTheMap { get; set; }
        public string PointsOfEwakness { get; set; }
        public string Threats  { get; set; }
        public int FeasibilityStudyId { get; set; }
        public Feasibility_study feasibility_study { get; set; }
        public ICollection <Competitors> competitors { get; set; }
        public ICollection<Expected_revenue> expected_Revenues { get; set; }
        public ICollection<Marketing_Activity> marketing_Activities { get; set; }
        public ICollection<Risk> risks { get; set; }
       
    }
}
