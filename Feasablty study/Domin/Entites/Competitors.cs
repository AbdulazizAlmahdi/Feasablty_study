using Feasablty_study.Domin.Interfaces;

namespace Feasablty_study.Models
{
    public class Competitors :IEntityBase
    {
        public int Id { get; set; }
        public string CompetitorsName { get; set; }
        public string Products { get; set; }
        public double CompetitorsPrice { get; set; }
        public int AmounrAdded { get; set; }
        public int MarketStudyId { get; set; }
        public Market_study market_Study { get; set; }

    }
}
