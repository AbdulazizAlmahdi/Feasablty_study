using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Risk : IEntityBase
    {
        public int Id { get; set; }
        public string TypeRisk { get; set; }
        public string DescriptionRisk { get; set; }
        public string DangerReductionStyle { get; set; }
        public string DescriptionDangerReduece { get; set; }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }

    }
}
