using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Expected_revenue : IEntityBase
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public float ProductPrice { get; set; }
        public int MonthlyQusntity { get; set; }
        public float TotalMonthlyPrice
        {
            get { return ProductPrice *MonthlyQusntity; }
           
            set
            {
                value = ProductPrice * MonthlyQusntity;
            }
        }   
        public float TotalYearlyPrice
        {
            get { return TotalMonthlyPrice*12; }
           
            set
            {
                value = TotalMonthlyPrice * 12;
            }
        }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
