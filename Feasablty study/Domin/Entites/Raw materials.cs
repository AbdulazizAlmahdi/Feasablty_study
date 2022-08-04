using Feasablty_study.Domin.Interfaces;

namespace Feasablty_study.Models
{
    public class Raw_materials : IEntityBase
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Unit { get; set; }
        public decimal PriceOfUnity { get; set; }
        public int QuantityRequiredMonthly { get; set; }
        public int TechnicalStudyId { get; set; }
        public Technical_Study technical_Study { get; set; }
    }
}
