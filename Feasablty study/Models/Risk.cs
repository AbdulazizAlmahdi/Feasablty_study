namespace Feasablty_study.Models
{
    public class Risk
    {
        public int Id { get; set; }
        public string TypeRisk { get; set; }

        public string DescriptionRisk { get; set; }
        public string DangerReductionStyle { get; set; }
        public string DescriptionDangerReduece { get; set; }
        public int MarketStudyId { get; set; }
        public Market_study market_Study { get; set; }

    }
}
