using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace Feasablty_study.Models
{
    public class Marketing_Activity : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public int MarketStudyId { get; set; }
        public Market_study market_Study { get; set; }
        

    }
}
