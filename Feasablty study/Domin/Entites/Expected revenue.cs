using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Expected_revenue : IEntityBase
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double ProductPrice { get; set; }
        public int MonthlyQusntity { get; set; }
        public double TotalMonthlyPrice
        {
            get { return ProductPrice *MonthlyQusntity; }
           
            set
            {
                _ = ProductPrice * MonthlyQusntity;
            }
        }   
        public double TotalYearlyPrice
        {
            get { return TotalMonthlyPrice*12; }
           
            set
            {
                _ = TotalMonthlyPrice * 12;
            }
        }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
