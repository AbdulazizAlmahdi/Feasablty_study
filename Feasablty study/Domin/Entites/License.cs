using Feasablty_study.Domin.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Feasablty_study.Models
{
    public class License : IEntityBase
    {
        public int Id { get; set; }
        public string LicenseType { get; set; }
        public string Licenses { get; set; }
        [ForeignKey("Feasibility_study")]
        public virtual int Feasibility_StudyId { get; set; }
        public virtual Feasibility_study Feasibility_Study { get; set; }
    }
}
