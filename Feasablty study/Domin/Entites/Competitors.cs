using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class Competitors :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        public string CompetitorsName { get; set; }
        public string Products { get; set; }
        public double CompetitorsPrice { get; set; }
        public int AmounrAdded { get; set; }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }

    }
}
