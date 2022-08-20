using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Manpower_workforce : IEntityBase
    {
        public int Id { get; set; } 
        public string JobTitle { get; set; }
        public int Number { get; set; }
        public double MonthlySalary { get; set; }
        public double TotalMonthlySalary { 
            get { return MonthlySalary*Number; }
            set
            {
                _ = MonthlySalary * Number;
            }
             }  
        public double TotalYearlySalary { 
            get { return TotalMonthlySalary * 12; }
            set
            {
                _ = TotalMonthlySalary*12;
            }
             }
        
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }



    }
}
