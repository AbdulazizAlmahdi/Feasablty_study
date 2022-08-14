using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Government_fees : IEntityBase
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float  Price{ get; set; }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
