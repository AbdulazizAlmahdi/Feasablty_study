namespace Feasablty_study.Models
{
    public class Expected_revenue
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int MonthlyQusntity { get; set; }
        public int MarketStudyId { get; set; }
        public Market_study market_Study { get; set; }
    }
}
