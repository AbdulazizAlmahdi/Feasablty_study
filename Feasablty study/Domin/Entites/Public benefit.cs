using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Models
{
    public class Public_benefit
    {
        [Key]
        public int Id { get; set; }
        public string Benefit  { get; set; }
        public decimal MonthlyCost { get; set; }
        public Technical_Study technical_Study { get; set; }
        public int TechnicalStudyId { get; set; }

    }
}
