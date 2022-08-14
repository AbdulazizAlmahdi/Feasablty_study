using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Raw_materials : IEntityBase
    {
        public int Id { get; set; }
        public string Material { get; set; }
        public string Unit { get; set; }
        public float PriceOfUnity { get; set; }
        public int QuantityRequiredMonthly { get; set; }
        public float TotalPriceQuantityMonthly {
            get {return PriceOfUnity *QuantityRequiredMonthly;}
            set
            {
                value = QuantityRequiredMonthly * PriceOfUnity;
            }
        }     
        public float TotalPriceQuantityYearly {
            get { return TotalPriceQuantityMonthly * 12; }
            set
            {
                value = TotalPriceQuantityMonthly*12;
            }
        }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
