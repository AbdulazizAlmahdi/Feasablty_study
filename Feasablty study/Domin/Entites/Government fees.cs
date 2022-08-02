namespace Feasablty_study.Models
{
    public class Government_fees
    {
        public int Id { get; set; }
        public string NameFees { get; set; }
        public string  DrawingDomestic{ get; set; }
        public int TechnicalStudyId { get; set; }
        public Technical_Study technical_Study { get; set; }
    }
}
