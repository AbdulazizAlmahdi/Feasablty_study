using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Public_benefit : IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string Benefit  { get; set; }
        public float MonthlyCost { get; set; }
        public float YearlyCost {
            get { return MonthlyCost*12; }
            set
            {
                value = MonthlyCost * 12;
            }
                }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }

    }
}
